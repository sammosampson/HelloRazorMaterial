using HelloRazorMaterial.Core.Html.Mdc.Generation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HelloRazorMaterial.Core.Html.Mdc.TagHelpers;

[HtmlTargetElement("mdc-card-ripple")]
public class MdcCardRippleTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = RippleGenerator.GenerateCardRipple();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}