
namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Home
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

    [Authorize]
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Home) });
        }
    }
}
