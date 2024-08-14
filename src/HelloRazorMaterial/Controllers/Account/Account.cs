namespace HelloRazorMaterial.Controllers.Account
{
    using HelloRazorMaterial.Controllers.Shared;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class Account : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new MenuModel { Items = MenuItemsBuilder.BuildWithSelectedName(nameof(Account)) });
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm]AccountModel details)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Home.Home.Index), nameof(Home.Home));
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            return RedirectToAction(nameof(Index), nameof(Account));
        }
    }
}
