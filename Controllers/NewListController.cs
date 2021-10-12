
using ShopWithMe.Models;
using ShopWithMe.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;


namespace ShopWithMe.Controllers
{

    public class NewListController : Controller
    {

        private readonly ICosmosDb_NewList_Service _cosmosDbService;
        private readonly ICosmosDbService _cosmosDbService1;


        public NewListController(ICosmosDb_NewList_Service cosmosDbService, ICosmosDbService cosmosDbService1)
        {
            _cosmosDbService = cosmosDbService;
            _cosmosDbService1 = cosmosDbService1;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            var alllists = await _cosmosDbService.Get_NewLists_Async("SELECT * FROM c");
            List<NewList> res = new List<NewList>();
            foreach (var temp in alllists)
            {
                if (temp.UserId == User.Identity.Name)
                {
                    res.Add(temp);
                }
            }
            return View(res);
        }

        [ActionName("CreateNewlist")]
        public async Task<IActionResult> CreateNewlist(List<string> listproducts, List<string> favorites)
        {
            Favorites_Products favorites_products = new();
            if (favorites.Count is 0)
            {
                var ls = await _cosmosDbService1.GetItemsAsync("SELECT * FROM c");
                ls = await GetItemByName((List<Item>)ls);
                favorites_products.Favorites = new();
                favorites_products.Urls = new();
                foreach (Item item in ls)
                {
                    favorites_products.Favorites.Add(item.Name);
                    favorites_products.Urls.Add(item.Url);
                }

            }
            else
                favorites_products.Favorites = favorites;

            favorites_products.Products = listproducts;
            return View(favorites_products);
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

        public async Task<ActionResult> Save(string namelist, List<string> listproducts, List<string> favorites)
        {
            NewList newList = new();
            newList.UserId = User.Identity.Name;
            newList.NameList = namelist;
            newList.Id = Guid.NewGuid().ToString();
            newList.Products = new();

            foreach (string product in listproducts)
            {
                string[] _toSplit = product.Split("=");
                newList.Products.Add(new Product(_toSplit[0], _toSplit[1]));

                if (!favorites.Contains(_toSplit[0].ToLower()))
                {
                    Item item = new();
                    item.Id = Guid.NewGuid().ToString();
                    item.UserId = User.Identity.Name;
                    item.Name = _toSplit[0].ToLower();
                    await _cosmosDbService1.AddItemAsync(item);
                }
            }

            await _cosmosDbService.Add_NewList_Async(newList);
            return RedirectToAction("Index");
        }

        [ActionName("Edit")]
        public async Task<IActionResult> Edit(string id, List<string> listproducts, List<string> favorites)
        {
            Favorites_Products favorites_products = new();
            favorites_products.IdList = id;
            if (favorites.Count is 0)
            {
                var ls = await _cosmosDbService1.GetItemsAsync("SELECT * FROM c");
                ls = await GetItemByName((List<Item>)ls);
                favorites_products.Favorites = new();
                favorites_products.Urls = new();
                foreach (Item item in ls)
                {
                    favorites_products.Favorites.Add(item.Name);
                    favorites_products.Urls.Add(item.Url);
                }


            }
            else
                favorites_products.Favorites = favorites;

            if (listproducts.Count is 0)
            {
                NewList newlist = await _cosmosDbService.Get_Newlist_Async(id);
                favorites_products.Products = new();
                foreach (Product product in newlist.Products)
                    favorites_products.Products.Add(product.ToString());
            }
            else
                favorites_products.Products = listproducts;
            return View(favorites_products);
        }


        public async Task<ActionResult> Update(string id, string listname, List<string> listproducts, List<string> favorites)
        {
            NewList newList = new();
            newList.UserId = User.Identity.Name;
            newList.NameList = listname;
            newList.Id = id;
            newList.Products = new();
            foreach (string product in listproducts)
            {
                string[] _toSplit = product.Split("=");
                newList.Products.Add(new Product(_toSplit[0], _toSplit[1]));
                if (!favorites.Contains(_toSplit[0].ToLower()))
                {
                    Item item = new();
                    item.Id = Guid.NewGuid().ToString();
                    item.UserId = User.Identity.Name;
                    item.Name = _toSplit[0].ToLower();
                    await _cosmosDbService1.AddItemAsync(item);
                }

            }

            await _cosmosDbService.Update_NewList_Async(newList.Id, newList);
            return RedirectToAction("Index");
        }


        public ActionResult Delete_product(string Page_type, string id, string Nameproduct, List<string> listproducts, List<string> favorites)
        {
            if (listproducts.Count > 1)
                for (int i = 0; i < listproducts.Count; i++)
                {
                    if (Nameproduct.Equals(listproducts[i]))
                    {
                        listproducts.Remove(listproducts[i]);
                        return RedirectToAction(Page_type, new { id = id, listproducts = listproducts, favorites = favorites });
                    }
                }
            return RedirectToAction(Page_type, new { id = id, listproducts = listproducts, favorites = favorites });
        }

        public ActionResult Add_Update(string Page_type, string id, string Nameproduct, int quantity, List<string> listproducts, List<string> favorites)
        {
            for (int i = 0; i < listproducts.Count; i++)
            {
                string[] productlist = listproducts[i].Split("=");
                if (Nameproduct.ToLower().Equals(productlist[0].ToLower()))
                {
                    listproducts[i] = $"{productlist[0]}={quantity}";
                    return RedirectToAction(Page_type, new { id = id, listproducts = listproducts, favorites = favorites });
                }
            }
            listproducts.Add($"{Nameproduct}={quantity}");
            return RedirectToAction(Page_type, new { id = id, listproducts = listproducts, favorites = favorites });
        }


        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            NewList newlist = await _cosmosDbService.Get_Newlist_Async(id);
            if (newlist == null)
            {
                return NotFound();
            }

            return View(newlist);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync(/*[Bind("Id")]*/ string id)
        {
            await _cosmosDbService.Delete_NewList_Async(id);
            return RedirectToAction("Index");
        }
    }
}



