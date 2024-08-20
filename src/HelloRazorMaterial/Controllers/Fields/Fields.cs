using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Fields
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    [Authorize]
    public class Fields : Controller
    {
        public IActionResult Index()
        {
            return View(new FieldsModel
            {
                Options = new[] { new SelectListItem { Text = "One", Value = "1" }, new SelectListItem { Text = "Two", Value = "2" } },
                ControllerName = nameof(Fields)
            });
        }
    }
}
