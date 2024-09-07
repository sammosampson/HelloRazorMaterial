using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
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