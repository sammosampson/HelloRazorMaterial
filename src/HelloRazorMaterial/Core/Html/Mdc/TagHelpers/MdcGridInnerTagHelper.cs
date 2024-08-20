namespace HelloRazorMaterial.Core.Html.Mdc.TagHelpers
{
    using HelloRazorMaterial.Core.Html.Mdc.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-grid-inner")]
    public class MdcGridInnerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder selectBuilder = GridGenerator.GenerateGridInner();
            output.TagName = selectBuilder.TagName;
            output.MergeAttributes(selectBuilder);
            output.PostContent.AppendHtml(selectBuilder.InnerHtml);
        }
    }
}
