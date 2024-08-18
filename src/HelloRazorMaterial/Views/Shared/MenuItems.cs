namespace HelloRazorMaterial.Views.Shared;

public static class MenuItems
{
    public static IEnumerable<MenuItem> GetItems(string controllerName) =>
        DefaultMenuItems
            .GetItems(controllerName)
            .Union(CustomMenuItems
                .GetItems(controllerName));
}