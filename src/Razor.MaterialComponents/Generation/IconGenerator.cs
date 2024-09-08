using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public class IconGenerator
    {
        public static TagBuilder GenerateDrawerIcon()
        {
            TagBuilder builder = GenerateIcon();
            builder.AddCssClass("mdc-deprecated-list-item__graphic");
            return builder;
        }

        public static TagBuilder GenerateButtonIcon()
        {
            TagBuilder builder = GenerateIcon();
            builder.AddCssClass("mdc-button__icon");
            return builder;
        }

        public static TagBuilder GenerateBannerIcon()
        {
            TagBuilder builder = GenerateIcon();
            builder.AddCssClass("mdc-banner__icon");
            return builder;
        }

        public static TagBuilder GenerateDropdownIcon()
        {
            var iconBuilder = new TagBuilder("span");
            iconBuilder.AddCssClass("mdc-select__dropdown-icon");

            TagBuilder iconSvgBuilder = SvgGenerator.GenerateSelectDropdown();
            var iconSvgContentBuilder = new HtmlContentBuilder();
            iconSvgContentBuilder.AppendLine(SvgGenerator.GenerateSelectDropdownInactivePolygon());
            iconSvgContentBuilder.AppendLine(SvgGenerator.GenerateSelectDropdownActivePolygon());
            iconSvgBuilder.InnerHtml.SetHtmlContent(iconSvgContentBuilder);

            iconBuilder.InnerHtml.SetHtmlContent(iconSvgBuilder);
            return iconBuilder;
        }

        private static TagBuilder GenerateIcon()
        {
            var builder = new TagBuilder("i");
            AddMaterialIconsClass(builder);
            builder.Attributes.Add("aria-hidden", "true");
            return builder;
        }

        public static void AddMaterialIconsClass(TagBuilder builder)
        {
            builder.AddCssClass("material-icons");
        }
    }
}