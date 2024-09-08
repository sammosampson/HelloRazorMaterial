using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers;

[HtmlTargetElement("mdc-top-app-bar")]
public class MdcTopAppBarTagHelper : TagHelper {
    public required string Id { get; set; }
    public MdcAppBarType BarType { get; set; }
    
    public override void Process(TagHelperContext context, TagHelperOutput output) {
        TagBuilder builder = AppBarGenerator.GenerateTopBar(Id, BarType);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}