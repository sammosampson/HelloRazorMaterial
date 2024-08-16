using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Fields
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Fields : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Fields) });
        }
    }
}
