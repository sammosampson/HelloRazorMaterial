using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Grids
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
