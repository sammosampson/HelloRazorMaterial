using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

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