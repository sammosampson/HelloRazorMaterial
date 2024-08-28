using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Mdc.Generation
{
    public static class FabGenerator
    {
        public static TagBuilder GenerateFab(string id, MdcFabType fabType, string icon, string label, bool touch, bool disabled)
        {
            TagBuilder builder = GenerateContainer(id, fabType, label, touch, disabled);
            var contentBuilder = new HtmlContentBuilder();

            contentBuilder.AppendHtml(RippleGenerator.GenerateFabRipple());
            contentBuilder.AppendHtml(GenerateIcon(icon));

            if (fabType == MdcFabType.Extended)
            {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }

            if (touch)
            {
                contentBuilder.AppendHtml(GenerateTouch());
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            if (touch)
            {
                var touchWrapperBuilder = TouchGenerator.GenerateTouchWrapper();
                touchWrapperBuilder.InnerHtml.SetHtmlContent(builder);
                return touchWrapperBuilder;
            }

            return builder;
        }


        private static TagBuilder GenerateContainer(string id, MdcFabType fabType, string label, bool touch, bool disabled)
        {
            var builder = new TagBuilder("button");
            builder.Attributes.Add("id", id);
            builder.Attributes.Add("aria-label", label);
            builder.AddCssClass("mdc-fab");

            switch (fabType)
            {
                case MdcFabType.Mini:
                    builder.AddCssClass("mdc-fab--mini");
                    break;
                case MdcFabType.Extended:
                    builder.AddCssClass("mdc-fab--extended");
                    break;
            }

            if (disabled)
            {
                builder.Attributes.Add("disabled", "");
            }

            if (touch)
            {
                builder.AddCssClass("mdc-fab--touch");
            }

            return builder;
        }

        private static IHtmlContent GenerateIcon(string icon)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("material-icons");
            builder.AddCssClass("mdc-fab__icon");
            builder.InnerHtml.SetContent(icon);
            return builder;
        }

        private static IHtmlContent GenerateLabel(string label)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-fab__label");
            builder.InnerHtml.SetContent(label);
            return builder;
        }

        private static TagBuilder GenerateTouch()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-fab__touch");
            return builder;
        }
    }
}
