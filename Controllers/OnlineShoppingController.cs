using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ShopWithMe.Hubs_Service;
using ShopWithMe.Models;
using ShopWithMe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Controllers
{
    public class OnlineShoppingController : Controller
    {
        private readonly IHubContext<Shopping> _hubContext;
        private readonly ICosmosDb_shoppingOL_Service cosmosDbService_Shopping;
        private readonly ICosmosDb_NewList_Service cosmosDbService_NewList;
        private readonly ICosmosDb_Invoice_Service cosmosDbService_Invoice;
        private readonly ICosmosDbService cosmosDbService_Item;
        private readonly IEmailSender _emailSender;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public OnlineShoppingController(ICosmosDb_NewList_Service cosmosDbServicenewlist, ICosmosDb_Invoice_Service cosmosDbServiceinvoice, ICosmosDbService cosmosDbService_item, IEmailSender emailSender, ICosmosDb_shoppingOL_Service cosmosDbService_shopping, IHttpContextAccessor httpContextAccessor, IHubContext<Shopping> hubContext)
        {
            _hubContext = hubContext;
            cosmosDbService_NewList = cosmosDbServicenewlist;
            cosmosDbService_Invoice = cosmosDbServiceinvoice;
            cosmosDbService_Item = cosmosDbService_item;
            cosmosDbService_Shopping = cosmosDbService_shopping;
            _emailSender = emailSender;
            _httpContextAccessor = httpContextAccessor;
        }

        [ActionName("Shopping")]
        public async Task<IActionResult> Shopping(string id)
        {
            shoppingOL container = new();
            container = await cosmosDbService_Shopping.Get_shoppingOL_Async(id);
            container.CartUrl = string.Concat(
                        HttpContext.Request.Scheme,
                        "://",
                        HttpContext.Request.Host.ToUriComponent(),
                        HttpContext.Request.PathBase.ToUriComponent(),
                        HttpContext.Request.Path.ToUriComponent(),
                        HttpContext.Request.QueryString.ToUriComponent());

            await cosmosDbService_Shopping.Update_shoppingOL_Async(id, container);

            return View(container);
        }

        [HttpPost]
        [ActionName("AddToCart")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart(shoppingOL container)
        {
            for (int i = 0; i < container.NewList.Proudcts.Count; i++)
            {
                if (container.NewList.Proudcts[i].Name.ToLower().Equals(container._proudct.Name.ToLower()))
                {
                    container.NewList.Proudcts[i].Quantity -= container._proudct.Quantity;
                }
            }

            for (int i = 0; i < container.Cart.Proudcts.Count; i++)
            {
                if (container.Cart.Proudcts[i].Name.ToLower().Equals(container._proudct.Name.ToLower()))
                {
                    container.Cart.Proudcts[i].Quantity += container._proudct.Quantity;
                    container.Cart.Proudcts[i].Price += (container._proudct.Quantity * container._proudct.Price);
                    container.Cart.Total += (container._proudct.Quantity * container._proudct.Price);
                    return View("Shopping", container);
                }
            }
            container._proudct.Price = (container._proudct.Quantity * container._proudct.Price);
            container.Cart.Proudcts.Add(container._proudct);
            container.Cart.Total += container._proudct.Price;

            await cosmosDbService_Shopping.Update_shoppingOL_Async(container.id, container);
            await _hubContext.Clients.All.SendAsync("ShoppingListUpdated");
            return View("Shopping", container);
        }

        [HttpPost]
        [ActionName("Delete_product")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete_product(shoppingOL container)
        {
            if (container.action is "NewList")
                container.NewList.Proudcts.Remove(container.NewList.Proudcts.Find(r => r.Name == container._proudct.Name));
            else
            {
                Proudct proudct2 = container.NewList.Proudcts.Find(r => r.Name == container._proudct.Name);
                proudct2.Quantity += container._proudct.Quantity;
                container.Cart.Total -= container._proudct.Price;
                container.Cart.Proudcts.Remove(container.Cart.Proudcts.Find(r => r.Name == container._proudct.Name));

            }
            await cosmosDbService_Shopping.Update_shoppingOL_Async(container.id, container);

            return View("Shopping", container);
        }

        [HttpPost]
        [ActionName("Add_Update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add_Update(shoppingOL container)
        {
            if (container.NewList.Proudcts.Count >= 1)
            {
                foreach (Proudct item in container.NewList.Proudcts)
                {
                    if (item.Name.ToLower().Equals(container._proudct.Name.ToLower()))
                    {
                        item.Quantity = container._proudct.Quantity;
                        return View("Shopping", container);
                    }
                }
            }
            container.NewList.Proudcts.Add(container._proudct);
            await cosmosDbService_Shopping.Update_shoppingOL_Async(container.id, container);

            return View("Shopping", container);
        }


        [HttpPost]
        [ActionName("Save_and_finish")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save_and_finish(shoppingOL container)
        {
            var ls = await cosmosDbService_Item.GetItemsAsync("SELECT * FROM c");
            ls = await GetItemByName(ls.ToList());
            List<Item> Favorites = ls.ToList();
            NewList list = await cosmosDbService_NewList.Get_Newlist_Async(container.NewList.Id);
            bool bo = false;
            foreach (Proudct product in container.NewList.Proudcts)
            {
                if (!Favorites.Exists(x => x.Name.ToLower() == product.Name.ToLower()))
                {
                    list.Proudcts.Add(new(product.Name, product.Quantity = 1));
                    bo = true;
                    Item item = new();
                    item.Id = Guid.NewGuid().ToString();
                    item.UserId = User.Identity.Name;
                    item.Name = product.Name;
                    item.Url = "https://icons.iconarchive.com/icons/paomedia/small-n-flat/128/shop-icon.png";
                    await cosmosDbService_Item.AddItemAsync(item);
                }
            }
            if (bo)
            {
                await cosmosDbService_NewList.Update_NewList_Async(list.Id, list);
            }
            container.Cart.Id = container.id;
            container.Cart.UserId = User.Identity.Name;
            container.Cart.Date_Time = DateTime.Now;
            await cosmosDbService_Invoice.Add_Invoice_Async(container.Cart);
            await cosmosDbService_Shopping.Update_shoppingOL_Async(container.id, container);

            return RedirectToAction("Details", "Invoice", new { id = container.Cart.Id });
        }

        public async Task<IEnumerable<Item>> GetItemByName(List<Item> items)
        {
            List<Item> res = new List<Item>();
            foreach (var temp in items)
            {
                if (temp.UserId == User.Identity.Name)
                {
                    res.Add(temp);
                }
            }
            return res;
        }

        [HttpPost]
        [ActionName("Invite")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Invite(shoppingOL container, string Email)
        {
            string url = container.CartUrl;

            await _emailSender.SendEmailAsync(Email, "Invited", url);

            return RedirectToAction("Shopping", "OnlineShopping", new { id = container.Cart.Id });
        }
    }
}