namespace HelloRazorMaterial.Core.Html.TagHelpers
{
    using HelloRazorMaterial.Core.Html.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System;

    [HtmlTargetElement("mdc-select")]
    public partial class MdcSelectTagHelper : TagHelper
    {
        public required string Label { get; set; }
        public required string Name { get; set; }
        public string? Id { get; set; }
        public bool FullWidth { get; set; } = true;
        public IEnumerable<SelectListItem> Options { get; set; } = new List<SelectListItem>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder selectBuilder = SelectGenerator.GenerateSelect(Id, Name, Label, FullWidth, Options);

            output.TagName = selectBuilder.TagName;
            output.MergeAttributes(selectBuilder);

            if (selectBuilder.HasInnerHtml)
            {
                output.PostContent.AppendHtml(selectBuilder.InnerHtml);
            }
        }
    }
}
