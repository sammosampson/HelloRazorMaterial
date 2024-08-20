namespace HelloRazorMaterial.Core.Html.TagHelpers
{
    using HelloRazorMaterial.Core.Html;
    using HelloRazorMaterial.Core.Html.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-field")]
    public class MdcFieldTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public required string Label { get; set; }
        public string? Name { get; set; }
        public ModelExpression? For { get; set; }
        public MdcFieldType FieldType { get; set; }
        public MdcVariant Variant { get; set; }
        public bool Required { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = FieldGenerator.GenerateField(Id, Label, Name, For?.Model.ToString(), FieldType, Variant, Required);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
