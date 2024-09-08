using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Home;

namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Views.Shared;

public static class DefaultMenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
    [
        MenuItem.CreateMenuItem(nameof(Home), "home", controllerName),
    ];
}