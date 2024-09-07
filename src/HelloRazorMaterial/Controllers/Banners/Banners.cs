using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Banners
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Banners : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Banners) });
        }
    }
}
