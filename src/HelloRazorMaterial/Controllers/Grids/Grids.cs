using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Grids
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Grids : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Grids) });
        }
    }
}
