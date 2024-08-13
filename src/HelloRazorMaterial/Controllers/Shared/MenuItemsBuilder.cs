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
                CreateMenuItem(nameof(Home.Home), "home", nameOfSelectedItem)
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