namespace HelloRazorMaterial.Controllers.Shared
{
    using System;
    using System.Collections.Generic;

    public class MenuItemsBuilder
    {
        public static IEnumerable<MenuItem> BuildWithSelectedName(string nameOfSelectedItem)
        {
            return new List<MenuItem>()
            { 
                CreateMenuItem(nameof(Home.Home), "home", nameOfSelectedItem),
                CreateMenuItem(nameof(Charts.Charts), "layers", nameOfSelectedItem),
                CreateMenuItem(nameof(Fields.Fields), "library_add_check", nameOfSelectedItem),
                CreateMenuItem(nameof(Buttons.Buttons), "description", nameOfSelectedItem),
                CreateMenuItem(nameof(Text.Text), "trending_up", nameOfSelectedItem),
                CreateMenuItem(nameof(Home2.Home2), "menu", nameOfSelectedItem)
            };
        }

        private static MenuItem CreateMenuItem(string name, string icon, string nameOfSelectedItem)
        {
            return new MenuItem
            {
                Name = name,
                Icon = icon,
                IsSelected = nameOfSelectedItem == name
            };
        }
    }
}