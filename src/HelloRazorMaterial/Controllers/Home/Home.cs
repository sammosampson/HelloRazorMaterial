
namespace HelloRazorMaterial.Controllers.Home
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using HelloRazorMaterial.Controllers.Shared;

    [Authorize]
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Home)) });
        }
    }
}
