using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Mdc.Generation;

namespace SystemDot.Web.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-drawer")]
    public class MdcDrawerTagHelper : TagHelper
    {
        public required string Id { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = DrawerGenerator.GenerateDrawer(Id);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}