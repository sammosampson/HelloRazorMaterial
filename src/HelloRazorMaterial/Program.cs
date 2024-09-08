using HelloRazorMaterial.Abstractions;
using HelloRazorMaterial.Controllers.Fields;
using HelloRazorMaterial.Controllers.Login;
using HelloRazorMaterial.Controllers.Options;
using HelloRazorMaterial.Pipeline.Charts;
using Microsoft.VisualBasic;

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
