namespace HelloRazorMaterial.Controllers.Login
{
    using HelloRazorMaterial.Abstractions;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    [AllowAnonymous]
    public class Login : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm]LoginModel details)
        {
            if (ModelState.IsValid)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, details.Email)
                };

                var claimsIdentity = new ClaimsIdentity(claims, AuthorisationConstants.CookieAuth);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(AuthorisationConstants.CookieAuth, claimsPrincipal);
                return RedirectToAction(nameof(Home.Home.Index), nameof(Home.Home));
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }
    }
}
