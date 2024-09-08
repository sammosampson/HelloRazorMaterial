using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Text
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Text : Controller
    {
        public IActionResult Index()
        {
            return View(new TextModel { ControllerName = nameof(Text) });
        }
    }
}
