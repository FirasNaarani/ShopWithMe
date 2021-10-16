using Microsoft.AspNetCore.Mvc;
using ShopWithMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("Create")]
        public IActionResult Create()
        {
            // fill the ContainerData data as u want 
            var model = new test()
            {
                FName = "my product",
                ListProducts = new List<Proudct>() {
                new Proudct()
                {
                    Name ="prod 1",
                    Quantity = "2"
                }
                }
            };
            //var ContainerData = new ContainerData() { test = model, dataInternl = new secretDataAdminData() { mydata = "fdfdfd" ,mydata2="232323"} };
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(/*[Bind("id,name,role,price")]*/ ContainerData item)
        {
            if (ModelState.IsValid)
            {
              

                return RedirectToAction("Create");
            }
            // user should not see this data load from database insert into test
            // save it to db
            return View(item);
        }
    }
}
