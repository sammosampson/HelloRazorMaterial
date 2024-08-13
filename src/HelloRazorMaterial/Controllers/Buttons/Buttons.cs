using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Buttons
{
    using Microsoft.AspNetCore.Mvc;

    public class Buttons : Controller
    {
        public IActionResult Index()
        {
            return View(new ButtonsModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Buttons)) });
        }
    }
}
