using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Buttons
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
