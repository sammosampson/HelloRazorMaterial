using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Mdc.Generation;

namespace SystemDot.Web.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-drawer-item")]
    public class MdcDrawerItemTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public required string Href { get; set; }
        public string? Text { get; set; }
        public string? Icon { get; set; }
        public bool Selected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = DrawerItemGenerator.GenerateDrawerItem(Id, Href, Text, Icon, Selected);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}