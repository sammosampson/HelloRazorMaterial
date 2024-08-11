using HelloRazorMaterial.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace HelloRazorMaterial.Controllers.Home2
{
    public class Home2 : Controller
    {
        public IActionResult Index()
        {
            return View(new Home2Model { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Home.Home)) });
        }
    }
}
