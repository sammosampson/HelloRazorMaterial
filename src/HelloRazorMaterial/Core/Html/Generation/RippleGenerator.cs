namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;

    public static class RippleGenerator
    {
        public static TagBuilder GenerateListItemRipple()
        {
            var rippleBuilder = new TagBuilder("span");
            rippleBuilder.AddCssClass("mdc-list-item__ripple");
            return rippleBuilder;
        }

        public static TagBuilder GenerateSelectRipple()
        {
            var selectRippleBuilder = new TagBuilder("span");
            selectRippleBuilder.AddCssClass("mdc-select__ripple");
            return selectRippleBuilder;
        }

        public static TagBuilder GenerateLineRipple()
        {
            var lineRippleBuilder = new TagBuilder("span");
            lineRippleBuilder.AddCssClass("mdc-line-ripple");
            return lineRippleBuilder;
        }

        public static IHtmlContent GenerateButtonRipple()
        {
            var buttonRippleBuilder = new TagBuilder("span");
            buttonRippleBuilder.AddCssClass("mdc-button__ripple");
            return buttonRippleBuilder;
        }

        internal static IHtmlContent? GenerateFabRipple()
        {
            var fabRippleBuilder = new TagBuilder("span");
            fabRippleBuilder.AddCssClass("mdc-fab__ripple");
            return fabRippleBuilder;
        }
    }
}
