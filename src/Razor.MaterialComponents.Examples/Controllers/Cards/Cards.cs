using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Cards
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
