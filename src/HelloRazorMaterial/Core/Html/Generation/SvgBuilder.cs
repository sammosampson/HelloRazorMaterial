namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class SvgBuilder
    {
        public static TagBuilder GenerateSvg(string cssClass, string viewBox)
        {
            var iconSvgBuilder = new TagBuilder("svg");
            iconSvgBuilder.AddCssClass(cssClass);
            iconSvgBuilder.Attributes.Add("viewBox", viewBox);
            return iconSvgBuilder;
        }

        public static IHtmlContent GenerateSvgPolygon(string cssClass, string points)
        {
            var polygonBuilder = new TagBuilder("polygon");
            polygonBuilder.AddCssClass(cssClass);
            polygonBuilder.Attributes.Add("stroke", "none");
            polygonBuilder.Attributes.Add("fill-rule", "evenodd");
            polygonBuilder.Attributes.Add("points", points);
            return polygonBuilder;
        }
    }
}
