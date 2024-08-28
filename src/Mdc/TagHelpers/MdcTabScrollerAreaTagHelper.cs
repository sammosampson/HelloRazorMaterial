using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

[HtmlTargetElement("mdc-tab-scroller-area")]
public class MdcTabScrollerAreaTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = TabBarGenerator.GenerateTabScrollerArea();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}
