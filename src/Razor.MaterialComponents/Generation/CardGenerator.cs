using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class CardGenerator
    {
        public static TagBuilder GenerateCard(MdcCardType cardType)
        {
            var builder = new TagBuilder("div");

            builder.AddCssClass("mdc-card");
            if(cardType == MdcCardType.Outlined)
            {
                builder.AddCssClass("mdc-card--outlined");
            }

            return builder;
        }

        public static TagBuilder GeneratePrimaryAction() {
            var builder = new TagBuilder("div");

            builder.AddCssClass("mdc-card__primary-action");
            builder.Attributes.Add("tabindex", "0");

            return builder;
        }

        public static TagBuilder GenerateContent() {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-card__content");

            return builder;
        }

        public static TagBuilder GenerateCardMedia(MdcCardMediaSize mediaSize) {
            var builder = new TagBuilder("div");

            builder.AddCssClass("mdc-card__media");
            switch (mediaSize) {
                case MdcCardMediaSize.SixteenNine:
                    builder.AddCssClass("mdc-card__media--16-9");
                    break;
                case MdcCardMediaSize.Square:
                    builder.AddCssClass("mdc-card__media--square");
                    break;
            }

            return builder;
        }

        public static TagBuilder GenerateMediaContent() {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-card__media-content");

            return builder;
        }

        public static TagBuilder GenerateActions()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-card__actions");

            return builder;
        }

        public static TagBuilder GenerateActionButtons()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-card__action-buttons");

            return builder;
        }

        public static TagBuilder GenerateActionIcons()
        {
            var builder = new TagBuilder("div");
            builder.AddCssClass("mdc-card__action-icons");

            return builder;
        }
    }
}
