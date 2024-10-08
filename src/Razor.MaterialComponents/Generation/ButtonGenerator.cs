﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation {
    public static class ButtonGenerator {
        public static TagBuilder GenerateButton(string id, string? label, MdcButtonType buttonType,
            MdcIconType iconType, string? icon, bool ripple, bool focusRing, bool touch, bool disabled) {
            TagBuilder builder = GenerateContainer(id, buttonType, iconType, touch, disabled);
            var contentBuilder = new HtmlContentBuilder();

            if (ripple) {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
            }

            if (focusRing) {
                contentBuilder.AppendHtml(GenerateFocusRing());
            }

            if (touch) {
                contentBuilder.AppendHtml(GenerateTouch());
            }

            if (label != null && iconType != MdcIconType.Leading) {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }

            if (icon != null) {
                TagBuilder iconBuilder = IconGenerator.GenerateButtonIcon();
                iconBuilder.InnerHtml.SetContent(icon);
                contentBuilder.AppendHtml(iconBuilder);
            }

            if (label != null && iconType == MdcIconType.Leading) {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        public static TagBuilder GenerateCardActionButton(string id, string? label, bool ripple, bool touch, bool disabled) {
            TagBuilder builder = GenerateContainer(id, MdcButtonType.None, MdcIconType.None, false, disabled);
            builder.AddCssClass("mdc-card__action");
            builder.AddCssClass("mdc-card__action--button");

            var contentBuilder = new HtmlContentBuilder();

            if (ripple) {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
            }

            if (touch) {
                contentBuilder.AppendHtml(GenerateTouch());
            }

            if (label != null) {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        public static TagBuilder GenerateTopAppBarNavIconButton(string id, string? title, bool ripple, bool touch, bool disabled) {
            TagBuilder builder = GenerateBaseContainer(id, touch, disabled);
            IconGenerator.AddMaterialIconsClass(builder);
            AddIconButtonClass(builder);
            builder.AddCssClass("mdc-top-app-bar__navigation-icon");

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

            return builder;
        }

        public static TagBuilder GenerateBannerPrimaryActionButton(MdcBannerActionType type, string? label, bool ripple)
        {
            TagBuilder builder = GenerateContainer();
            builder.AddCssClass($"mdc-banner__{type.ToString().ToLower()}-action");

            var contentBuilder = new HtmlContentBuilder();

            if (ripple)
            {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
            }

            if (label != null)
            {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        public static TagBuilder GenerateTopAppBarActionIconButton(string id, string? label, bool ripple, bool touch, bool disabled)
        {
            TagBuilder builder = GenerateBaseContainer(id, touch, disabled);
            IconGenerator.AddMaterialIconsClass(builder);
            AddIconButtonClass(builder);
            builder.AddCssClass("mdc-top-app-bar__action-item");

            if (label != null)
            {
                builder.Attributes.Add("aria-label", label);
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

            return builder;
        }

        public static TagBuilder GenerateCardActionIconButton(string id, string? title, bool ripple, bool touch, bool disabled) {
            TagBuilder builder = GenerateContainer(id, MdcButtonType.None, MdcIconType.None, touch, disabled);
            IconGenerator.AddMaterialIconsClass(builder);
            AddIconButtonClass(builder);
            builder.AddCssClass("mdc-card__action");
            builder.AddCssClass("mdc-card__action--icon");

            if (title != null) {
                builder.Attributes.Add("title", title);
            }

            var contentBuilder = new HtmlContentBuilder();

            if (ripple) {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
            }

            if (touch) {
                contentBuilder.AppendHtml(GenerateTouch());
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        public static TagBuilder GenerateDialogHeaderCloseButton(string id) {
            var builder = new TagBuilder("button");
            builder.Attributes.Add("id", id);
            IconGenerator.AddMaterialIconsClass(builder);
            AddIconButtonClass(builder);
            builder.AddCssClass("mdc-dialog__close");
            AddDialogAction(MdcActionType.Close, builder);
            builder.InnerHtml.SetContent("close");
            return builder;
        }

        public static TagBuilder GenerateDialogActionButton(string id, string? label, MdcActionType actionType, bool @default, bool ripple, bool touch, bool disabled) {
            TagBuilder builder = GenerateContainer(id, MdcButtonType.None, MdcIconType.None, touch, disabled);
            builder.AddCssClass("mdc-dialog__button");

            if (@default) {
                builder.AddCssClass("data-mdc-dialog-button-default");
            }

            if (actionType != MdcActionType.None) {
                AddDialogAction(actionType, builder);
            }

            var contentBuilder = new HtmlContentBuilder();

            if (ripple) {
                contentBuilder.AppendHtml(RippleGenerator.GenerateButtonRipple());
            }
            
            if (touch) {
                contentBuilder.AppendHtml(GenerateTouch());
            }

            if (label != null) {
                contentBuilder.AppendHtml(GenerateLabel(label));
            }

            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        private static TagBuilder GenerateContainer()
        {
            var builder = new TagBuilder("button");
            builder.AddCssClass("mdc-button");
            return builder;
        }

        private static TagBuilder GenerateContainer(string id, MdcButtonType buttonType, MdcIconType iconType, bool touch, bool disabled) {
            var builder = GenerateBaseContainer(id, touch, disabled);
            builder.AddCssClass("mdc-button");

            switch (iconType) {
                case MdcIconType.Leading:
                    builder.AddCssClass("mdc-button--icon-leading");
                    break;
                case MdcIconType.Trailing:
                    builder.AddCssClass("mdc-button--icon-trailing");
                    break;
            }

            switch (buttonType) {
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

            return builder;
        }

        private static TagBuilder GenerateBaseContainer(string id, bool touch, bool disabled)
        {
            var builder = new TagBuilder("button");
            builder.Attributes.Add("id", id);
            
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

        private static TagBuilder GenerateFocusRing() {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-button__focus-ring");
            return builder;
        }

        private static TagBuilder GenerateTouch() {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-button__touch");
            return builder;
        }


        private static IHtmlContent GenerateLabel(string label) {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-button__label");
            builder.InnerHtml.SetContent(label);
            return builder;
        }

        private static void AddIconButtonClass(TagBuilder builder)
        {
            builder.AddCssClass("mdc-icon-button");
        }

        private static void AddDialogAction(MdcActionType actionType, TagBuilder builder)
        {
            builder.Attributes.Add("data-mdc-dialog-action", GetActionType(actionType));
        }

        private static string GetActionType(MdcActionType actionType) {
            switch (actionType) {
                case MdcActionType.Ok:
                    return "ok";
                case MdcActionType.Accept:
                    return "accept";
                case MdcActionType.Close:
                    return "close";
            }

            throw new NotImplementedException();
        }
    }
}
