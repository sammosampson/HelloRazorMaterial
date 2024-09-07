using HelloRazorMaterial.Controllers.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HelloRazorMaterial.Controllers.Dialogs
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
