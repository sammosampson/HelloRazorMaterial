namespace HelloRazorMaterial.Core.Html.Mdc.Generation
{
    using Microsoft.AspNetCore.Mvc.Rendering;

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