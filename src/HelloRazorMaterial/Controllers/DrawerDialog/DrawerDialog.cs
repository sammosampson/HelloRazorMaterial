using HelloRazorMaterial.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace HelloRazorMaterial.Controllers.DrawerDialog
{
    public class DrawerDialog : Controller
    {
        public IActionResult Index()
        {
            return View(new DrawerDialogModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Home.Home)) });
        }
    }
}
