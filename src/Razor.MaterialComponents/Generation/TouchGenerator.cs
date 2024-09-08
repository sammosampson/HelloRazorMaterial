using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public class TouchGenerator
    {
        public static TagBuilder GenerateTouchWrapper()
        {
            TagBuilder builder = new TagBuilder("div");
            builder.AddCssClass("mdc-touch-target-wrapper");
            return builder;
        }
    }
}