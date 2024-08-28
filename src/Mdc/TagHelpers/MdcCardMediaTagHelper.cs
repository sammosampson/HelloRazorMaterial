using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

[HtmlTargetElement("mdc-card-media")]
public class MdcCardMediaTagHelper : TagHelper
{
    public MdcCardMediaSize MediaSize { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = CardGenerator.GenerateCardMedia(MediaSize);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}