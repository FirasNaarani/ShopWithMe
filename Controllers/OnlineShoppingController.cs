using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        private readonly ICosmosDb_NewList_Service cosmosDbService_NewList;
        private readonly ICosmosDb_Invoice_Service cosmosDbService_Invoice;
        private readonly ICosmosDbService cosmosDbService_Item;


        public OnlineShoppingController(ICosmosDb_NewList_Service cosmosDbServicenewlist, ICosmosDb_Invoice_Service cosmosDbServiceinvoice, ICosmosDbService cosmosDbService_item)
        {
            cosmosDbService_NewList = cosmosDbServicenewlist;
            cosmosDbService_Invoice = cosmosDbServiceinvoice;
            cosmosDbService_Item = cosmosDbService_item;
        }

        [ActionName("Shopping")]
        public async Task<IActionResult> Shopping(string id)
        {
            ContainerDataOnlineShopping container = new();
            container.newList = await cosmosDbService_NewList.Get_Newlist_Async(id);
            container.cart.NameCart = $"{container.newList.NameList} Cart";
            return View(container);
        }

        [HttpPost]
        [ActionName("AddToCart")]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(ContainerDataOnlineShopping container)
        {
            for (int i = 0; i < container.newList.Proudcts.Count; i++)
            {
                if (container.newList.Proudcts[i].Name.ToLower().Equals(container._proudct.Name.ToLower()))
                {
                    container.newList.Proudcts[i].Quantity -= container._proudct.Quantity;
                }
            }

            for (int i = 0; i < container.cart.Proudcts.Count; i++)
            {
                if (container.cart.Proudcts[i].Name.ToLower().Equals(container._proudct.Name.ToLower()))
                {
                    container.cart.Proudcts[i].Quantity += container._proudct.Quantity;
                    container.cart.Proudcts[i].Price += (container._proudct.Quantity * container._proudct.Price);
                    container.cart.Total += (container._proudct.Quantity * container._proudct.Price);
                    return View("Shopping", container);
                }
            }
            container._proudct.Price = (container._proudct.Quantity * container._proudct.Price);
            container.cart.Proudcts.Add(container._proudct);
            container.cart.Total += container._proudct.Price;
            return View("Shopping", container);
        }

        [HttpPost]
        [ActionName("Delete_product")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete_product(ContainerDataOnlineShopping container)
        {
            if (container.action is "NewList")
                container.newList.Proudcts.Remove(container.newList.Proudcts.Find(r => r.Name == container._proudct.Name));
            else
            {
                Proudct proudct2 = container.newList.Proudcts.Find(r => r.Name == container._proudct.Name);
                proudct2.Quantity += container._proudct.Quantity;
                container.cart.Total -= container._proudct.Price;
                container.cart.Proudcts.Remove(container.cart.Proudcts.Find(r => r.Name == container._proudct.Name));

            }
            return View("Shopping", container);
        }

        [HttpPost]
        [ActionName("Add_Update")]
        [ValidateAntiForgeryToken]
        public ActionResult Add_Update(ContainerDataOnlineShopping container)
        {
            if (container.newList.Proudcts.Count >= 1)
            {
                foreach (Proudct item in container.newList.Proudcts)
                {
                    if (item.Name.ToLower().Equals(container._proudct.Name.ToLower()))
                    {
                        item.Quantity = container._proudct.Quantity;
                        return View("Shopping", container);
                    }
                }
            }
            container.newList.Proudcts.Add(container._proudct);
            return View("Shopping", container);
        }


        [HttpPost]
        [ActionName("Save_and_finish")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save_and_finish(ContainerDataOnlineShopping container)
        {
            var ls = await cosmosDbService_Item.GetItemsAsync("SELECT * FROM c");
            ls = await GetItemByName(ls.ToList());
            List<Item> Favorites = ls.ToList();
            NewList list = await cosmosDbService_NewList.Get_Newlist_Async(container.newList.Id);
            bool bo = false;
            foreach (Proudct product in container.newList.Proudcts)
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
            container.cart.Id = Guid.NewGuid().ToString();
            container.cart.UserId = User.Identity.Name;
            container.cart.Date_Time = DateTime.Now;
            await cosmosDbService_Invoice.Add_Invoice_Async(container.cart);
            return RedirectToAction("Details", "Invoice", new { id = container.cart.Id });
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
    }
}