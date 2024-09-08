using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public class DrawerItemGenerator
    {
        public static TagBuilder GenerateDrawerItem(string id, string href, string? text, string? icon, bool selected)
        {
            var builder = new TagBuilder("a");
            builder.Attributes.Add("id", id);
            builder.Attributes.Add("href", href);
            builder.Attributes.Add("aria-current", "page");
            builder.AddCssClass("mdc-deprecated-list-item");

            if (selected)
            {
                builder.AddCssClass("mdc-deprecated-list-item--activated");
            }

            var contentBuilder = new HtmlContentBuilder();

            contentBuilder.AppendHtml(RippleGenerator.GenerateDrawerItemRipple());


            if (icon != null)
            {
                var iconBuiilder = IconGenerator.GenerateDrawerIcon();
                iconBuiilder.InnerHtml.SetContent(icon);
                contentBuilder.AppendHtml(iconBuiilder);
            }

            if (text != null)
            {
                contentBuilder.AppendHtml(GenerateText(text));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        private static IHtmlContent? GenerateText(string text)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-deprecated-list-item__text");
            builder.InnerHtml.SetContent(text);
            return builder;
        }
    }
}