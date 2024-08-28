using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Mdc.Generation
{
    public class TabBarGenerator
    {
        public static TagBuilder GenerateTabBar()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-tab-bar");
            builder.Attributes.Add("role", "tablist");
            return builder;
        }

        public static TagBuilder GenerateTabScroller()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-tab-scroller");
            return builder;
        }

        public static TagBuilder GenerateTabScrollerArea()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-tab-scroller__scroll-area");
            return builder;
        }

        public static TagBuilder GenerateTabScrollerContent()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-tab-scroller__scroll-content");
            return builder;
        }
    }
}