namespace HelloRazorMaterial.Core.Html.Mdc.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AppBarGenerator
    {
        public static TagBuilder GenerateButton(string id, string? title, bool menu)
        {
            var builder = new TagBuilder("header");
            builder.Attributes.Add("id", id);
            builder.AddCssClass("mdc-top-app-bar");
            builder.AddCssClass("mdc-top-app-bar--fixed");
            builder.InnerHtml.SetHtmlContent(GenerateRow(title, menu));
            return builder;
        }

        private static IHtmlContent GenerateRow(string? title, bool menu)
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-top-app-bar__row");
            builder.InnerHtml.SetHtmlContent(GenerateStartSection(title, menu));
            return builder;
        }

        private static IHtmlContent GenerateStartSection(string? title, bool menu)
        {
            var builder = new TagBuilder("section");
            builder.AddCssClass("mdc-top-app-bar__section");
            builder.AddCssClass("mdc-top-app-bar__section--align-start");

            var contentBuilder = new HtmlContentBuilder();
            if (menu)
            {
                contentBuilder.AppendHtml(GenerateMenu());
            }
            if (title is not null)
            {
                contentBuilder.AppendHtml(GenerateTitle(title));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);
            return builder;
        }

        private static IHtmlContent GenerateMenu()
        {
            var builder = new TagBuilder("button");
            builder.AddCssClass("material-icons");
            builder.AddCssClass("mdc-top-app-bar__navigation-icon");
            builder.AddCssClass("mdc-icon-button");
            builder.InnerHtml.SetContent("menu");
            return builder;
        }

        private static IHtmlContent GenerateTitle(string title)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-top-app-bar__title");
            builder.InnerHtml.SetContent(title);
            return builder;
        }
    }
}