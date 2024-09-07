using HelloRazorMaterial.Controllers.Banners;
using HelloRazorMaterial.Controllers.Buttons;
using HelloRazorMaterial.Controllers.Cards;
using HelloRazorMaterial.Controllers.Fields;
using HelloRazorMaterial.Controllers.Text;
using HelloRazorMaterial.Controllers.Grids;
using HelloRazorMaterial.Controllers.Tabs;
using HelloRazorMaterial.Controllers.Account;
using HelloRazorMaterial.Controllers.DataTables;
using HelloRazorMaterial.Controllers.Dialogs;

namespace HelloRazorMaterial.Views.Shared;

public static class CustomMenuItems
{
    public static IEnumerable<MenuItem> Get(string controllerName) =>
    [
        MenuItem.CreateMenuItem(nameof(Charts), "trending_up", controllerName),
        MenuItem.CreateMenuItem(nameof(Fields), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Banners), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Buttons), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Text), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Grids), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Cards), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Tabs), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(DataTables), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Dialogs), "description", controllerName),
        MenuItem.CreateMenuItem(nameof(Account), "description", controllerName)
    ]; 
}