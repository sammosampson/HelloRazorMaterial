namespace HelloRazorMaterial.Core.Html.Mdc.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class LabelGenerator
    {
        public static TagBuilder GenerateFloatingLabel(string id, string label)
        {
            var labelBuilder = new TagBuilder("span");
            labelBuilder.AddCssClass("mdc-floating-label");
            labelBuilder.Attributes.Add("id", id);
            labelBuilder.InnerHtml.SetContent(label);
            return labelBuilder;
        }

    }
}
