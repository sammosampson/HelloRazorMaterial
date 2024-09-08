using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class SvgGenerator
    {
        public static TagBuilder GenerateCheckboxCheckmark()
        {
            return SvgGenerator.GenerateSvg("mdc-checkbox__checkmark", "0 0 24 24");
        }

        public static TagBuilder GenerateCheckboxCheckmarkPath()
        {
            return SvgGenerator.GenerateSvgPath("mdc-checkbox__checkmark-path", "M1.73,12.91 8.1,19.28 22.79,4.59");
        }

        public static TagBuilder GenerateSelectDropdown()
        {
            return SvgGenerator.GenerateSvg("mdc-select__dropdown-icon-graphic", "7 10 10 5");
        }

        public static IHtmlContent GenerateSelectDropdownInactivePolygon()
        {
            return SvgGenerator.GenerateSvgPolygon("mdc-select__dropdown-icon-inactive", "7 10 12 15 17 10");
        }
        public static IHtmlContent GenerateSelectDropdownActivePolygon()
        {
            return SvgGenerator.GenerateSvgPolygon("mdc-select__dropdown-icon-active", "7 15 12 10 17 15");
        }

        public static TagBuilder GenerateSvg(string cssClass, string viewBox)
        {
            var iconSvgBuilder = new TagBuilder("svg");
            iconSvgBuilder.AddCssClass(cssClass);
            iconSvgBuilder.Attributes.Add("viewBox", viewBox);
            return iconSvgBuilder;
        }

        public static TagBuilder GenerateSvgPolygon(string cssClass, string points)
        {
            var polygonBuilder = new TagBuilder("polygon");
            polygonBuilder.AddCssClass(cssClass);
            polygonBuilder.Attributes.Add("stroke", "none");
            polygonBuilder.Attributes.Add("fill-rule", "evenodd");
            polygonBuilder.Attributes.Add("points", points);
            return polygonBuilder;
        }

        public static TagBuilder GenerateSvgPath(string cssClass, string points)
        {
            var polygonBuilder = new TagBuilder("path");
            polygonBuilder.AddCssClass(cssClass);
            polygonBuilder.Attributes.Add("fill", "none");
            polygonBuilder.Attributes.Add("d", points);
            return polygonBuilder;
        }
    }
}
