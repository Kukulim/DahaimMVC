﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DahaimMVC.Areas.Shop.Models;

namespace DahaimMVC.Areas.Shop.Controllers
{
    public class ShopManagerController : Controller
    {
        private readonly ITypeData typeData;
        private readonly IProductData productData;
        private readonly IAuthorData authorData;

        public ShopManagerController(ITypeData typeData, IProductData productData, IAuthorData authorData)
        {
            this.typeData = typeData;
            this.productData = productData;
            this.authorData = authorData;
        }

        public ActionResult Index()
        {
            var model = productData.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.TypeId = new SelectList(typeData.GetAll(), "TypeId", "Name");
            ViewBag.AuthorId = new SelectList(authorData.GetAll(), "AuthorId", "AuthorName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productData.Add(product);
                return RedirectToAction("Index");
            }
            ViewBag.TypeId = new SelectList(typeData.GetAll(), "TypeId", "Name", product.TypeId);
            ViewBag.AuthorId = new SelectList(authorData.GetAll(), "AuthorId", "AuthorName", product.AuthorId);

            return View(product);
        }

    }
}