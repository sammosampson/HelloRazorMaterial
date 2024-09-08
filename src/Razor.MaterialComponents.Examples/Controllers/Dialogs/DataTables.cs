using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Dialogs
{
    [Authorize]
    public class Dialogs : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Dialogs) });
        }
    }
}
