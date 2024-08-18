using HelloRazorMaterial.Controllers.Home;

namespace HelloRazorMaterial.Views.Shared;

public static class DefaultMenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
    [
        MenuItem.CreateMenuItem(nameof(Home), "home", controllerName),
    ];
}