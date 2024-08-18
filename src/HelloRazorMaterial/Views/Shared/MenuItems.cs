namespace HelloRazorMaterial.Views.Shared;

public static class MenuItems
{
    public static IEnumerable<MenuItem> GetItems(string controllerName) =>
        DefaultMenuItems
            .Get(controllerName)
            .Union(CustomMenuItems
                .Get(controllerName));
}