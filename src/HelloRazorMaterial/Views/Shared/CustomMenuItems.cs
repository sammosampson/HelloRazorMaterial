using HelloRazorMaterial.Controllers.Buttons;
using HelloRazorMaterial.Controllers.Cards;
using HelloRazorMaterial.Controllers.Charts;
using HelloRazorMaterial.Controllers.Fields;
using HelloRazorMaterial.Controllers.Text;
using HelloRazorMaterial.Controllers.Grids;

namespace HelloRazorMaterial.Views.Shared;

public static class CustomMenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
    [
        MenuItem.CreateMenuItem(nameof(Charts), "trending_up", controllerName),
        MenuItem.CreateMenuItem(nameof(Fields), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Buttons), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Text), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Grids), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Cards), "description", controllerName)
    ]; 
}