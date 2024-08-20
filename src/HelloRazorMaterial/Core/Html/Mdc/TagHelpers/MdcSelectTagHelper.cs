namespace HelloRazorMaterial.Core.Html.Mdc.TagHelpers
{
    using HelloRazorMaterial.Core.Html.Mdc;
    using HelloRazorMaterial.Core.Html.Mdc.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-select")]
    public class MdcSelectTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public required string Label { get; set; }
        public string? Name { get; set; }
        public ModelExpression? For { get; set; }
        public IEnumerable<SelectListItem>? Items { get; set; }
        public MdcVariant Variant { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = SelectGenerator.GenerateSelect(Id, Label, Name, For?.Model.ToString(), Items, Variant);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
