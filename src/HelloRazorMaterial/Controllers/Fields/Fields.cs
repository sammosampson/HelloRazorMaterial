﻿using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Fields
{
    using Microsoft.AspNetCore.Mvc;

    public class Fields : Controller
    {
        public IActionResult Index()
        {
            return View(new FieldsModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Fields)) });
        }
    }
}
