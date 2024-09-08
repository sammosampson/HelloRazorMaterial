using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class LabelGenerator
    {
        public static TagBuilder GenerateFloatingLabel(string id, string label, bool floatAbove)
        {
            var labelBuilder = new TagBuilder("span");
            labelBuilder.Attributes.Add("id", id);
            labelBuilder.AddCssClass("mdc-floating-label");
            if (floatAbove)
            {
                labelBuilder.AddCssClass("mdc-floating-label--float-above");
            }
            labelBuilder.InnerHtml.SetContent(label);
            return labelBuilder;
        }

        public static TagBuilder GenerateLabelFor(string @for, string label)
        {
            var labelBuilder = new TagBuilder("label");
            labelBuilder.Attributes.Add("for", @for);
            labelBuilder.InnerHtml.SetContent(label);
            return labelBuilder;
        }
    }
}
