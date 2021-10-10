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
            var allitems = await _cosmosDbService.GetItemsAsync("SELECT * FROM c");
            List<Item> res = new List<Item>();
            foreach (var temp in allitems)
            {
                var st = User;
                if (temp.UserId == User.Identity.Name)
                {
                    res.Add(temp);
                }
            }
            return View(res);
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
                string userId = User.Identity.Name.ToString();
                item.UserId = userId;
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
                await _cosmosDbService.UpdateItemAsync(item.Id, item.Name, item);
                return RedirectToAction("Index");
            }

            return View(item);
        }


        [ActionName("Edit")]
        public async Task<ActionResult> EditAsync(string id, string name)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id, name);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(string id, string name)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Item item = await _cosmosDbService.GetItemAsync(id, name);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync(/*[Bind("Id,name")]*/ string id, string name)
        {
            await _cosmosDbService.DeleteItemAsync(id, name);
            return RedirectToAction("Index");
        }

        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id, string name)
        {
            return View(await _cosmosDbService.GetItemAsync(id, name));
        }

    }

}
