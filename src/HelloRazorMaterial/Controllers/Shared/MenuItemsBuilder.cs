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
                CreateMenuItem(nameof(Charts.Charts), "trending_up", nameOfSelectedItem),
                CreateMenuItem(nameof(Fields.Fields), "description", nameOfSelectedItem),
                CreateMenuItem(nameof(Buttons.Buttons), "description", nameOfSelectedItem),
                CreateMenuItem(nameof(Text.Text), "description", nameOfSelectedItem)
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