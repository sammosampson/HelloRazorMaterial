namespace HelloRazorMaterial.Core.Html.TagHelpers
{
    using HelloRazorMaterial.Core.Html;
    using HelloRazorMaterial.Core.Html.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;

    [HtmlTargetElement("mdc-select")]
    public partial class MdcSelectTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public required string Label { get; set; }
        public string? Name { get; set; }
        public ModelExpression? For { get; set; }
        public IEnumerable<SelectListItem>? Items { get; set; }
        public MdcVariant Variant { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder selectBuilder = SelectGenerator.GenerateSelect(Id, Label, Name, For?.Model.ToString(), Items, Variant);
            output.TagName = selectBuilder.TagName;
            output.MergeAttributes(selectBuilder);
            output.PostContent.AppendHtml(selectBuilder.InnerHtml);
        }
    }
}
