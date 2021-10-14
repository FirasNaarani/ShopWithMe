﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWithMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Controllers
{
    public class CartOnlineController : Controller
    {

        // GET: CartOnlineController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CartOnlineController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartOnlineController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartOnlineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartOnlineController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartOnlineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartOnlineController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartOnlineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
