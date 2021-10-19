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

        private readonly ICosmosDb_NewList_Service _cosmosDbService;

        public OnlineShoppingController(ICosmosDb_NewList_Service cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [ActionName("Shopping")]
        public async Task<IActionResult> Shopping(string id)
        {
            ContainerDataOnlineShopping container = new();
            container.newList = await _cosmosDbService.Get_Newlist_Async(id);
            container.cart.NameCart =$"{container.newList.NameList} cart";

            return View(container);
        }

        [HttpPost]
        [ActionName("AddToCart")]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(ContainerDataOnlineShopping container)
        {
            container._proudct.Price = (container._proudct.Quantity * container._proudct.Price);
            container.cart.Proudcts.Add(container._proudct);
            container.cart.Price += container._proudct.Price;
            return View("Shopping",container);
        }
    }
}
