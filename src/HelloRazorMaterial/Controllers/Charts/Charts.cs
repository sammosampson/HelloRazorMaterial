namespace HelloRazorMaterial.Controllers.Charts
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Charts : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Colour> colours = [Colour.Red, Colour.Blue, Colour.Yellow];

            return View(
                new ChartsModel
                {
                    Data = [300, 50, 100],
                    Labels = colours.Select(c => c.Name).ToArray(),
                    Colours = colours.Select(c => c.ToRgbValue()).ToArray(),
                    ControllerName = nameof(Charts)
                }
            );
        }
    }
}
