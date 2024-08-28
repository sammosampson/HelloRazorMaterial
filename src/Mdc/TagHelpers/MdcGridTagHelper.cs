using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-grid")]
    public class MdcGridTagHelper : TagHelper
    {
        public bool FixedColumnWidth { get; set; }
        public MdcGridAlignment Align { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = GridGenerator.GenerateGrid(FixedColumnWidth, Align);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
