using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers
{
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
