using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Text
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
