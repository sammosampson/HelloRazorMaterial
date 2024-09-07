using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public class BannerGenerator
    {
        public static TagBuilder GenerateBanner(bool centered, bool stacked)
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.AddCssClass("mdc-banner");
            tagBuilder.Attributes.Add("role", "banner");

            if (centered) 
            {
                tagBuilder.AddCssClass("mdc-banner--centered");
            }

            if (centered)
            {
                tagBuilder.AddCssClass("mdc-banner--mobile-stacked");
            }

            return tagBuilder;
        }

        public static TagBuilder GenerateBannerFixed()
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.AddCssClass("mdc-banner__fixed");
            return tagBuilder;
        }

        public static TagBuilder GenerateBannerContent()
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.AddCssClass("mdc-banner__content");
            tagBuilder.Attributes.Add("role", "alertdialog");
            tagBuilder.Attributes.Add("aria-live", "assertive");
            return tagBuilder;
        }

        public static TagBuilder GenerateBannerGraphicTextWrapper()
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.AddCssClass("mdc-banner__graphic-text-wrapper");
            return tagBuilder;
        }

        public static TagBuilder GenerateBannerText()
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.AddCssClass("mdc-banner__text");
            return tagBuilder;
        }

        public static TagBuilder GenerateBannerActions()
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.AddCssClass("mdc-banner__actions");
            return tagBuilder;
        }

        public static TagBuilder GenerateBannerGraphic()
        {
            TagBuilder tagBuilder = new TagBuilder("div");
            tagBuilder.AddCssClass("mdc-banner__graphic");
            tagBuilder.Attributes.Add("role", "img");
            return tagBuilder;
        }
    }
}