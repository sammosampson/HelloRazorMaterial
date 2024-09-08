using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers;

[HtmlTargetElement("mdc-top-app-bar-title")]
public class MdcTopAppBarTitleTagHelper : TagHelper
{

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = AppBarGenerator.GenerateTopBarTitle();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}