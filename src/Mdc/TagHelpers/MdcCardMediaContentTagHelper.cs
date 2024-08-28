using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Mdc.Generation;

namespace SystemDot.Web.Mdc.TagHelpers;

[HtmlTargetElement("mdc-card-media-content")]
public class MdcCardMediaContentTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = CardGenerator.GenerateMediaContent();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}