﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers;

[HtmlTargetElement("mdc-data-table-body")]
public class MdcDataTableBodyTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DataTableGenerator.GenerateTableBody();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}