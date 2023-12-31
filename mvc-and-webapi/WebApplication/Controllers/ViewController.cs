﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace WebApplication.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            string uri = "https://localhost:44385/data/index";

            HttpResponseMessage response = client.GetAsync(uri).Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ViewBag.Title = data;
            }
            else
            {
                ViewBag.Title = "Error";
            }

            return View();
        }

        // GET: View/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: View/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: View/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: View/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: View/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: View/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: View/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
