using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public class OutlineGenerator
    {
        public static TagBuilder GenerateNotchedOutline()
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-notched-outline");
            return builder;
        }

        public static TagBuilder GenerateNotchedOutlineLeading()
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-notched-outline__leading");
            return builder;
        }

        public static TagBuilder GenerateNotchedOutlineNotch()
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-notched-outline__notch");
            return builder;
        }

        public static TagBuilder GenerateNotchedOutlineTrailing()
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-notched-outline__trailing");
            return builder;
        }
    }
}