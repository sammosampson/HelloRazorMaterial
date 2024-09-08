namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Views.Shared;

public static class MenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
        DefaultMenuItems
            .Get(controllerName)
            .Union(CustomMenuItems.Get(controllerName));
}