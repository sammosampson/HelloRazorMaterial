﻿using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.DataTables
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class DataTables : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(DataTables) });
        }
    }
}
