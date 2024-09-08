using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json.Linq;
using SystemDot.Web.Razor.MaterialComponents.Generation;

namespace SystemDot.Web.Razor.MaterialComponents.TagHelpers
{
    [HtmlTargetElement("mdc-text-field")]
    public class MdcTextFieldTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public required string Label { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public ModelExpression? For { get; set; }
        public MdcFieldType FieldType { get; set; }
        public MdcVariant Variant { get; set; }
        public bool Required { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
        public string? Class { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = TextFieldGenerator.GenerateTextField(Id, Label, Name, Value ?? For?.Model?.ToString(), FieldType, Variant, Prefix, Suffix, Class, Required);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
