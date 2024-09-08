using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class TabButtonGenerator
    {
        public static TagBuilder GenerateTabButton(string id, string? name, string? value, string? label, string? icon, int index, bool selected, bool disabled)
        {
            var builder = new TagBuilder("button");
            builder.Attributes.Add("id", id);
            builder.AddCssClass("mdc-tab");
            builder.Attributes.Add("role", "tab");
            builder.Attributes.Add("tabindex", index.ToString());

            if (name is not null)
            {
                builder.Attributes.Add("name", name);
                builder.Attributes.Add("type", "submit");
            }

            if(value is not null)
            {
                builder.Attributes.Add("value", value);
            }

            if (disabled)
            {
                builder.Attributes.Add("disabled", "");
            }

            if (selected)
            {
                builder.AddCssClass("mdc-tab--active");
                builder.Attributes.Add("aria-selected", "true");
            }

            var contentBuilder = new HtmlContentBuilder();
            contentBuilder.AppendHtml(GenerateContent(label, icon));
            contentBuilder.AppendHtml(GenerateIndicator(selected));
            contentBuilder.AppendHtml(RippleGenerator.GenerateTabRipple());

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        private static TagBuilder GenerateContent(string? label, string? icon)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-tab__content");

            var contentBuilder = new HtmlContentBuilder();
            if (icon != null)
            {
                contentBuilder.AppendHtml(GenerateIcon(icon));
            }
            if (label != null)
            {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);
            return builder;
        }

        private static IHtmlContent GenerateIcon(string icon)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("material-icons");
            builder.AddCssClass("mdc-tab__icon");
            builder.Attributes.Add("aria-hidden", "true");
            builder.InnerHtml.SetContent(icon);
            return builder;
        }

        private static IHtmlContent GenerateLabel(string label)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-tab__text-label");
            builder.InnerHtml.SetContent(label);
            return builder;
        }

        private static TagBuilder GenerateIndicator(bool selected)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-tab-indicator");

            if(selected)
            {
                builder.AddCssClass("mdc-tab-indicator--active");
            }

            var contentBuilder = new HtmlContentBuilder();
            builder.InnerHtml.SetHtmlContent(GenerateIndicatorContent(selected));
            return builder;
        }

        private static TagBuilder GenerateIndicatorContent(bool selected)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-tab-indicator__content");
            if (selected)
            {
                builder.AddCssClass("mdc-tab-indicator__content--underline");
            }
            return builder;
        }
    }
}
