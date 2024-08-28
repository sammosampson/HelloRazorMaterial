using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Mdc.Generation;

namespace SystemDot.Web.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-app-bar")]
    public class MdcAppBarTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public string? Title { get; set; }
        public bool MenuButton { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = AppBarGenerator.GenerateButton(Id, Title, MenuButton);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}