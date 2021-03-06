﻿using ERP1._0.Business;
using ERP1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ERP1._0.Controllers
{
  
    public class HomeController : Controller
    {
        ClsBusiness _bussiness = new ClsBusiness();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel Model)
        {
            if (Model != null)
            {
                if (!string.IsNullOrEmpty(Model.EmailID) && !string.IsNullOrEmpty(Model.Password))
                {
                    long UserID = _bussiness.Login(Model.EmailID, Model.Password);
                    if (UserID > 0)
                    {
                        TempData["UserID"] = UserID;
                        return Redirect("/Dashboard/Index");
                    }
                    else
                    {
                        ViewBag.Message = "Incorrect User name or password";
                        return View();
                    }
                }
            }
            return View();
        }
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
