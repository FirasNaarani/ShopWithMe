using Microsoft.AspNetCore.Mvc;
using ShopWithMe.Models;
using ShopWithMe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Controllers
{
    public class ItemController : Controller
    {
        private readonly ICosmosDbService _cosmosDbService;

        public ItemController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            var ls = await _cosmosDbService.GetItemsAsync("SELECT * FROM c");
            ls = await GetItemByName(ls.ToList());
            List<Item> res = ls.ToList();
            return View(res);
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

        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(/*[Bind("id,name,role,price")]*/ Item item)
        {
            if (ModelState.IsValid)
            {
                item.Id = Guid.NewGuid().ToString();
                item.UserId = User.Identity.Name;
                item.Name = item.Name.ToLower();
                await _cosmosDbService.AddItemAsync(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(/*[Bind("id,name,role,price")]*/ Item item)
        {
            if (ModelState.IsValid)
            {
                item.UserId = User.Identity.Name;
                await _cosmosDbService.UpdateItemAsync(item.Id, item);
                return RedirectToAction("Index");
            }

            return View(item);
        }


        [ActionName("Edit")]
        public async Task<ActionResult> EditAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync(/*[Bind("Id,name")]*/ string id)
        {
            await _cosmosDbService.DeleteItemAsync(id);
            return RedirectToAction("Index");
        }

        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id)
        {
            return View(await _cosmosDbService.GetItemAsync(id));
        }

    }

}
