using HelloRazorMaterial.Controllers.Home;

namespace HelloRazorMaterial.Views.Shared;

public static class DefaultMenuItems
{
    public static IEnumerable<MenuItem> GetItems(string controllerName) =>
    [
        CreateMenuItem(nameof(Home), "home", controllerName),
    ];

    public static MenuItem CreateMenuItem(string name, string icon, string nameOfSelectedItem)
    {
        return new MenuItem
        {
            Name = name,
            Icon = icon,
            IsSelected = nameOfSelectedItem == name
        };
    }  
}