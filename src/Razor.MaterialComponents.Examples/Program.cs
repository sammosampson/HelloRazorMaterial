using SystemDot.Web.Razor.MaterialCompontents.Examples.Abstractions;
using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Fields;
using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Login;
using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Options;
using SystemDot.Web.Razor.MaterialCompontents.Examples.Pipeline.Charts;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllersWithViews();

builder.Services.AddSingleton<FieldModelCache>();
builder.Services.AddSingleton<OptionsModelCache>();

builder.Services
    .AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetChartsViewDataRequestHandler>());

builder.Services
    .AddAuthentication(AuthorisationConstants.CookieAuth)
    .AddCookie(AuthorisationConstants.CookieAuth, config =>
    {
        config.Cookie.Name = AuthorisationConstants.UserLoginCookie;
        config.LoginPath = $"/{nameof(Login)}";
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
