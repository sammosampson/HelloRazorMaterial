namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class RippleBuilder
    {
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
    }
}
