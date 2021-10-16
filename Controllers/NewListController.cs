
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
        public async Task<IActionResult> CreateNewlist()
        {
            ContainerData container = new("CreateNewlist");
            var ls = await _cosmosDbService1.GetItemsAsync("SELECT * FROM c");
            ls = await GetItemByName(ls.ToList());
            container.Favorites = ls.ToList();
            return View(container);
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
        [ActionName("Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(ContainerData container)
        {
            container.newList.Id = Guid.NewGuid().ToString();
            container.newList.UserId = User.Identity.Name;

            foreach (Proudct product in container.newList.Proudcts)
            {
                if (!container.Favorites.Exists(x => x.Name == product.Name))
                {
                    Item item = new();
                    item.Id = Guid.NewGuid().ToString();
                    item.UserId = User.Identity.Name;
                    item.Name = product.Name;
                    await _cosmosDbService1.AddItemAsync(item);
                }
            }
            await _cosmosDbService.Add_NewList_Async(container.newList);
            return RedirectToAction("Index");
        }


        [ActionName("Edit")]
        public async Task<IActionResult> Edit(string id)
        {
            ContainerData container = new("Edit");
            var ls = await _cosmosDbService1.GetItemsAsync("SELECT * FROM c");
            ls = await GetItemByName(ls.ToList());
            container.Favorites = ls.ToList();
            container.newList = await _cosmosDbService.Get_Newlist_Async(id);
            return View(container);
        }

        [HttpPost]
        [ActionName("Update")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(ContainerData container)
        {
            foreach (Proudct product in container.newList.Proudcts)
            {
                if (!container.Favorites.Exists(x => x.Name == product.Name))
                {
                    Item item = new();
                    item.Id = Guid.NewGuid().ToString();
                    item.UserId = User.Identity.Name;
                    item.Name = product.Name;
                    await _cosmosDbService1.AddItemAsync(item);
                }
            }
            await _cosmosDbService.Update_NewList_Async(container.newList.Id, container.newList);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ActionName("Delete_product")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete_product(ContainerData container)
        {
            container.newList.Proudcts.Remove(container.newList.Proudcts.Find(r => r.Name == container._product.Name));
            return View(container.Page_type,container);
        }

        [HttpPost]
        [ActionName("Add_Update")]
        [ValidateAntiForgeryToken]
        public ActionResult Add_Update(ContainerData container)
        {
            if (container.newList.Proudcts.Count >= 1)
            {
                foreach (Proudct item in container.newList.Proudcts)
                {
                    if (item.Name.Equals(container._product.Name))
                    {
                        item.Quantity = container._product.Quantity;
                        return View(container.Page_type, container);
                    }
                }
            }
            container.newList.Proudcts.Add(container._product);
            return View(container.Page_type, container);
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



