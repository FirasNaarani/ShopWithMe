using Microsoft.AspNetCore.Mvc;
using ShopWithMe.Models;
using ShopWithMe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ICosmosDb_Invoice_Service _cosmosDbService;
        private readonly ICosmosDb_shoppingOL_Service _cosmosDbService_Shopping;



        public InvoiceController(ICosmosDb_Invoice_Service cosmosDbService, ICosmosDb_shoppingOL_Service cosmosDb_ShoppingOL)
        {
            _cosmosDbService = cosmosDbService;
            _cosmosDbService_Shopping = cosmosDb_ShoppingOL;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            var ls = await _cosmosDbService.Get_Invoices_Async("SELECT * FROM c");
            ls = await GetCartByName(ls.ToList());
            List<Cart> res = ls.ToList();
            return View(res);
        }

        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id)
        {
            return View(await _cosmosDbService.Get_Invoice_Async(id));
        }

        public async Task<IEnumerable<Cart>> GetCartByName(List<Cart> Carts)
        {
            List<Cart> res = new();
            foreach (var temp in Carts)
            {
                if (temp.UserId == User.Identity.Name)
                {res.Add(temp);}                
            }
            return res;
        }


        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Cart cart = await _cosmosDbService.Get_Invoice_Async(id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAsync(string id)
        {
            await _cosmosDbService.Delete_Invoice_Async(id);
            await _cosmosDbService_Shopping.Delete_shoppingOL_Async(id);
            return RedirectToAction("Index");
        }

    }
}
