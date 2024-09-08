using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers;

[HtmlTargetElement("mdc-banner")]
public class MdcBannerTagHelper : TagHelper
{
    public bool Centered { get; set; }
    public bool Stacked { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = BannerGenerator.GenerateBanner(Centered, Stacked);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}