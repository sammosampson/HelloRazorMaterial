using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

[HtmlTargetElement("mdc-top-app-bar-section")]
public class MdcTopAppBarSectionTagHelper : TagHelper
{
    public MdcAppBarSectionAlignment Align { get; set; }
    public bool Toolbar { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = AppBarGenerator.GenerateTopBarSection(Align, Toolbar);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}