using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Mdc.Generation;

namespace SystemDot.Web.Mdc.TagHelpers;

[HtmlTargetElement("mdc-card-action-icons")]
public class MdcCardActionIconsTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = CardGenerator.GenerateActionIcons();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}