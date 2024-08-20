namespace HelloRazorMaterial.Core.Html.Mdc.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;
    using System.Threading.Tasks;

    public class DrawerGenerator
    {
        public static async Task<TagBuilder> GenerateDrawer(string id, TagHelperOutput output)
        {
            var builder = new TagBuilder("aside");
            builder.Attributes.Add("id", id);
            builder.AddCssClass("mdc-drawer");
            builder.AddCssClass("mdc-drawer--modal");
            builder.InnerHtml.SetHtmlContent(await GenerateContent(output));
            return builder;
        }

        internal static TagBuilder GenerateDrawerScrim()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-drawer-scrim");
            return builder;
        }

        private static async Task<IHtmlContent> GenerateContent(TagHelperOutput output)
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-drawer__content");
            builder.InnerHtml.SetHtmlContent(await GenerateNav(output));
            return builder;
        }

        private static async Task<IHtmlContent> GenerateNav(TagHelperOutput output)
        {
            var builder = new TagBuilder("nav");
            builder.AddCssClass("mdc-deprecated-list");
            builder.InnerHtml.AppendHtml(await output.GetChildContentAsync());
            return builder;
        }
    }
}