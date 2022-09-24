﻿using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreproje.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository()); //categoryy manager sınıfından değer türeteceğiz.Icategorydalı karşılayacak değer göndereceğiz
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
