using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Mdc.Generation;

namespace SystemDot.Web.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-grid-cell")]
    public class MdcGridCellTagHelper : TagHelper
    {
        public int Span { get; set; }
        public int? Index { get; set; }
        public MdcGridCellAlignment Align { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder selectBuilder = GridGenerator.GenerateCell(Span, Index, Align);
            output.TagName = selectBuilder.TagName;
            output.MergeAttributes(selectBuilder);
            output.PostContent.AppendHtml(selectBuilder.InnerHtml);
        }
    }
}
