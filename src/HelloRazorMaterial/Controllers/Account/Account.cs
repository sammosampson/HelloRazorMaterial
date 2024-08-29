
namespace HelloRazorMaterial.Controllers.Account
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using HelloRazorMaterial.Controllers.Shared;

    [Authorize]
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View(new MenuModel { ControllerName = nameof(Account) });
        }
    }
}
