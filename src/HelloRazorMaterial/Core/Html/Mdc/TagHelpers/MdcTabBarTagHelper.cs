using HelloRazorMaterial.Core.Html.Mdc.Generation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HelloRazorMaterial.Core.Html.Mdc.TagHelpers;

[HtmlTargetElement("mdc-tab-bar")]
public class MdcTabBarTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = TabBarGenerator.GenerateTabBar();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}
