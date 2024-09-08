using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public class AppBarGenerator
    {
        public static TagBuilder GenerateTopBar(string id, MdcAppBarType barType) {
            var builder = new TagBuilder("header");
            builder.Attributes.Add("id", id);
            builder.AddCssClass("mdc-top-app-bar");
            switch (barType)
            {
                case MdcAppBarType.Fixed:
                    builder.AddCssClass("mdc-top-app-bar--fixed");
                    break;
                case MdcAppBarType.Short:
                    builder.AddCssClass("mdc-top-app-bar--short");
                    break;
            }
            return builder;
        }

        public static TagBuilder GenerateTopBarRow() {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-top-app-bar__row");
            return builder;
        }

        public static TagBuilder GenerateTopBarSection(MdcAppBarSectionAlignment alignment, bool toolbar) {
            var builder = new TagBuilder("section");
            builder.AddCssClass("mdc-top-app-bar__section");
            switch (alignment) {
                case MdcAppBarSectionAlignment.Start:
                    builder.AddCssClass("mdc-top-app-bar__section--align-start");
                    break;
                case MdcAppBarSectionAlignment.End:
                    builder.AddCssClass("mdc-top-app-bar__section--align-end");
                    break;
            }

            if (toolbar) {
                builder.Attributes.Add("role", "toolbar");
            }
            return builder;
        }

        public static TagBuilder GenerateTopBarTitle() {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-top-app-bar__title");
            return builder;
        }

        public static TagBuilder GenerateSuccinctBar(string id, MdcAppBarType barType, string? title, bool menu)
        {
            TagBuilder builder = GenerateTopBar(id, barType);
            builder.InnerHtml.SetHtmlContent(GenerateSuccinctRow(title, menu));
            return builder;
        }

        private static IHtmlContent GenerateSuccinctRow(string? title, bool menu)
        {
            TagBuilder builder = GenerateTopBarRow();
            builder.InnerHtml.SetHtmlContent(GenerateSuccinctStartSection(title, menu));
            return builder;
        }

        private static IHtmlContent GenerateSuccinctStartSection(string? title, bool menu)
        {
            var builder = GenerateTopBarSection(MdcAppBarSectionAlignment.Start, false);

            var contentBuilder = new HtmlContentBuilder();
            if (menu)
            {
                contentBuilder.AppendHtml(GenerateSuccinctMenuButton());
            }
            if (title is not null)
            {
                contentBuilder.AppendHtml(GenerateSuccinctTitle(title));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);
            return builder;
        }

        private static IHtmlContent GenerateSuccinctMenuButton()
        {
            var builder = ButtonGenerator.GenerateTopAppBarNavIconButton("menu", "menu", false, false, false);
            builder.InnerHtml.SetContent("menu");
            return builder;
        }

        private static IHtmlContent GenerateSuccinctTitle(string title)
        {
            var builder = GenerateTopBarTitle();
            builder.InnerHtml.SetContent(title);
            return builder;
        }
    }
}