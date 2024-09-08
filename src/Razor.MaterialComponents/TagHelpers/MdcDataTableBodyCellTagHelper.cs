using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers;

[HtmlTargetElement("mdc-data-table-body-cell")]
public class MdcDataTableBodyCellTagHelper : TagHelper
{
    public MdcCellType CellType { get; set; }
    public bool Key { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = Key ? DataTableGenerator.GenerateTableBodyCell(CellType) : DataTableGenerator.GenerateTableBodyKeyCell( CellType);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}