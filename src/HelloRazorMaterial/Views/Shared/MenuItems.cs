namespace HelloRazorMaterial.Views.Shared;

public static class MenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
        DefaultMenuItems
            .Get(controllerName)
            .Union(CustomMenuItems
                .Get(controllerName));
}