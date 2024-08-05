using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Charts
{
    using Microsoft.AspNetCore.Mvc;

    public class Charts : Controller
    {
        public IActionResult Index()
        {
            return View(new ChartsModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Charts)) });
        }
    }
}
