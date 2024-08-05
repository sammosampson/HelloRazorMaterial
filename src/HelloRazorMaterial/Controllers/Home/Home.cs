﻿using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Home
{
    using Microsoft.AspNetCore.Mvc;

    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Home)) });
        }
    }
}
