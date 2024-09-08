namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Options
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Options : Controller
    {
        private readonly OptionsModelCache cache;

        public Options(OptionsModelCache cache)
        {
            this.cache = cache;
        }

        public IActionResult Index()
        {
            OptionsModel model = cache.Get() ?? new OptionsModel();

            model = model with
            {
                ControllerName = nameof(Options)
            };

            return base.View(model);
        }

        [HttpPost]
        public IActionResult Index(OptionsModel model)
        {
            cache.Set(model); 
            return RedirectToAction();
        }
    }
}
