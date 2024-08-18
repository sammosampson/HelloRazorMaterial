using HelloRazorMaterial.Controllers.Buttons;
using HelloRazorMaterial.Controllers.Charts;
using HelloRazorMaterial.Controllers.Fields;
using HelloRazorMaterial.Controllers.Text;

namespace HelloRazorMaterial.Views.Shared;

public static class CustomMenuItems
{
    public static IEnumerable<MenuItem> GetItems(string controllerName) =>
    [
        DefaultMenuItems.CreateMenuItem(nameof(Charts), "trending_up", controllerName),
        DefaultMenuItems.CreateMenuItem(nameof(Fields), "description", controllerName),
        DefaultMenuItems.CreateMenuItem(nameof(Buttons), "description", controllerName),
        DefaultMenuItems.CreateMenuItem(nameof(Text), "description", controllerName)
    ]; 
}