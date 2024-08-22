using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Cards
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Cards : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Cards) });
        }
    }
}
