using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-text-area")]
    public class MdcTextAreaTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Label { get; set; }
        public int Cols { get; set; }
        public int Rows { get; set; }
        public ModelExpression? For { get; set; }
        public MdcVariant Variant { get; set; }
        public bool Required { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = TextAreaGenerator.GenerateTextArea(Id, Rows, Cols, Label, Name, Value ?? For?.Model?.ToString(), Variant, Required);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
