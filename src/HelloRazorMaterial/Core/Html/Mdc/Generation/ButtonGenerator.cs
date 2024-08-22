namespace HelloRazorMaterial.Core.Html.Mdc.Generation
{
    using HelloRazorMaterial.Core.Html.Mdc;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Reflection.Emit;

    public static class ButtonGenerator
    {
        public static TagBuilder GenerateButton(string id, string? label, MdcButtonType buttonType, MdcIconType iconType, string? icon, bool ripple, bool focusRing, bool touch, bool disabled)
        {
            TagBuilder builder = GenerateContainer(id, buttonType, iconType, touch, disabled);
            var contentBuilder = new HtmlContentBuilder();

            if (ripple)
            {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
            }
            if (focusRing)
            {
                contentBuilder.AppendHtml(GenerateFocusRing());
            }
            if (touch)
            {
                contentBuilder.AppendHtml(GenerateTouch());
            }
            if (label != null && iconType != MdcIconType.Leading)
            {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }
            if (icon != null)
            {
                contentBuilder.AppendHtml(GenerateIcon(icon));
            }
            if (label != null && iconType == MdcIconType.Leading)
            {
                contentBuilder.AppendHtml(GenerateLabel(label));
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

        public static TagBuilder GenerateCardActionButton(string id, string? label, bool ripple, bool touch, bool disabled) {
            TagBuilder builder = GenerateContainer(id, MdcButtonType.None, MdcIconType.None, false, disabled);
            builder.AddCssClass("mdc-card__action");
            builder.AddCssClass("mdc-card__action--button");
            
            var contentBuilder = new HtmlContentBuilder();

            if (ripple)
            {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
            }

            if (touch)
            {
                contentBuilder.AppendHtml(GenerateTouch());
            }

            if (label != null)
            {
                contentBuilder.AppendHtml(GenerateLabel(label));
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

        public static TagBuilder GenerateCardActionIconButton(string id, string? title, bool ripple, bool touch, bool disabled)
        {
            TagBuilder builder = GenerateContainer(id, MdcButtonType.None, MdcIconType.None, false, disabled);
            builder.AddCssClass("material-icons");
            builder.AddCssClass("mdc-icon-button");
            builder.AddCssClass("mdc-card__action");
            builder.AddCssClass("mdc-card__action--icon");
            
            if (title != null)
            {
                builder.Attributes.Add("title", title);
            }

            var contentBuilder = new HtmlContentBuilder();

            if (ripple)
            {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
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

        private static TagBuilder GenerateContainer(string id, MdcButtonType buttonType, MdcIconType iconType, bool touch, bool disabled)
        {
            var builder = new TagBuilder("button");
            builder.Attributes.Add("id", id);
            builder.AddCssClass("mdc-button");

            switch (iconType)
            {
                case MdcIconType.Leading:
                    builder.AddCssClass("mdc-button--icon-leading");
                    break;
                case MdcIconType.Trailing:
                    builder.AddCssClass("mdc-button--icon-trailing");
                    break;
            }

            switch (buttonType)
            {
                case MdcButtonType.Outlined:
                    builder.AddCssClass("mdc-button--outlined");
                    break;
                case MdcButtonType.Raised:
                    builder.AddCssClass("mdc-button--raised");
                    break;
                case MdcButtonType.Unelevated:
                    builder.AddCssClass("mdc-button--unelevated");
                    break;
            }

            if (disabled)
            {
                builder.Attributes.Add("disabled", "");
            }

            if (touch)
            {
                builder.AddCssClass("mdc-button--touch");
            }

            return builder;
        }

        private static TagBuilder GenerateFocusRing()
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-button__focus-ring");
            return builder;
        }

        private static TagBuilder GenerateTouch()
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-button__touch");
            return builder;
        }

        private static IHtmlContent GenerateIcon(string icon)
        {
            var builder = new TagBuilder("i");
            builder.AddCssClass("material-icons");
            builder.AddCssClass("mdc-button__icon");
            builder.Attributes.Add("aria-hidden", "true");
            builder.InnerHtml.SetContent(icon);
            return builder;
        }

        private static IHtmlContent GenerateLabel(string label)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-button__label");
            builder.InnerHtml.SetContent(label);
            return builder;
        }
    }
}
