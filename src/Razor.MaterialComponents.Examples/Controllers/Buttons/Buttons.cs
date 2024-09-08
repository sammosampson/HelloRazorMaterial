using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Buttons
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Buttons : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Buttons) });
        }
    }
}
