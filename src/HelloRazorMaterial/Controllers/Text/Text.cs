using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Text
{
    using Microsoft.AspNetCore.Mvc;

    public class Text : Controller
    {
        public IActionResult Index()
        {
            return View(new TextModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Text)) });
        }
    }
}
