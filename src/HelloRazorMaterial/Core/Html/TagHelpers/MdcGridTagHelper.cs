namespace HelloRazorMaterial.Core.Html.TagHelpers
{
    using HelloRazorMaterial.Core.Html.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-grid")]
    public class MdcGridTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder selectBuilder = GridGenerator.GenerateGrid();
            output.TagName = selectBuilder.TagName;
            output.MergeAttributes(selectBuilder);
            output.PostContent.AppendHtml(selectBuilder.InnerHtml);
        }
    }
}
