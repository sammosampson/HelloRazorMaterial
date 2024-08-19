using HelloRazorMaterial.Controllers.Buttons;
using HelloRazorMaterial.Controllers.Charts;
using HelloRazorMaterial.Controllers.Fields;
using HelloRazorMaterial.Controllers.Text;

namespace HelloRazorMaterial.Views.Shared;

public static class CustomMenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
    [
        MenuItem.CreateMenuItem(nameof(Charts), "trending_up", controllerName),
        MenuItem.CreateMenuItem(nameof(Fields), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Buttons), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Text), "description", controllerName)
    ]; 
}