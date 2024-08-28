using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Mdc.Generation;

namespace SystemDot.Web.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-drawer-scrim")]
    public class MdcDrawerScrimTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = DrawerGenerator.GenerateScrim();
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}