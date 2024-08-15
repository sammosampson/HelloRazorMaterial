namespace HelloRazorMaterial.Controllers.Logout
{
    using HelloRazorMaterial.Abstractions;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class Logout : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync(AuthorisationConstants.CookieAuth);
            return RedirectToAction(nameof(Index), nameof(Home.Home));
        }
    }
}
