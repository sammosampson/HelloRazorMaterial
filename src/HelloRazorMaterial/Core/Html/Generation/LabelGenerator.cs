namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class LabelGenerator
    {
        public static TagBuilder GenerateFloatingLabel(string label)
        {
            var labelBuilder = new TagBuilder("span");
            labelBuilder.AddCssClass("mdc-floating-label");
            labelBuilder.InnerHtml.SetContent(label);
            return labelBuilder;
        }

    }
}
