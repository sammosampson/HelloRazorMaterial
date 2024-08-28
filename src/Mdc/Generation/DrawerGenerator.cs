using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Mdc.Generation
{
    public class DrawerGenerator
    {
        public static TagBuilder GenerateDrawer(string id)
        {
            var builder = new TagBuilder("aside");
            builder.Attributes.Add("id", id);
            builder.AddCssClass("mdc-drawer");
            builder.AddCssClass("mdc-drawer--modal");
            return builder;
        }

        public static TagBuilder GenerateScrim()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-drawer-scrim");
            return builder;
        }

        public static TagBuilder GenerateContent()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-drawer__content");
            return builder;
        }

        public static TagBuilder GenerateNav()
        {
            var builder = new TagBuilder("nav");
            builder.AddCssClass("mdc-deprecated-list");
            return builder;
        }
    }
}