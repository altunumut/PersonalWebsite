﻿using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string p)
        {
            return View();
        }
    }
}
