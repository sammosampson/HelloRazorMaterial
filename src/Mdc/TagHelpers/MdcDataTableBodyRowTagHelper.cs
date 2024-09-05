using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

[HtmlTargetElement("mdc-data-table-body-row")]
public class MdcDataTableBodyRowTagHelper : TagHelper
{
    public bool Selected { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DataTableGenerator.GenerateTableBodyRow(Selected);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}