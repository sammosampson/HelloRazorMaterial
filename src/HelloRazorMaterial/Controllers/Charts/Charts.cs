using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Charts
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Charts : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Charts)) });
        }
    }
}
