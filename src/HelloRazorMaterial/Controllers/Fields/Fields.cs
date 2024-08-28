using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Fields
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    [Authorize]
    public class Fields : Controller
    {
        private readonly FieldModelCache cache;

        public Fields(FieldModelCache cache)
        {
            this.cache = cache;
        }

        public IActionResult Index()
        {
            FieldsModel model = cache.Get() ?? new FieldsModel();

            model = model with
            {
                Options = [new SelectListItem { Text = "One", Value = "1" }, new SelectListItem { Text = "Two", Value = "2" }],
                ControllerName = nameof(Fields)
            };

            return base.View(model);
        }

        [HttpPost]
        public IActionResult Index(FieldsModel model)
        {
            cache.Set(model); 
            return RedirectToAction();
        }
    }
}
