using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Mdc.Generation
{
    public static class TextFieldGenerator
    {
        public static TagBuilder GenerateTextField(string id, string? label, string? name, string? value, MdcFieldType fieldType, MdcVariant variant, bool required)
        {
            TagBuilder builder = FieldGenerator.GenerateFieldContainer(label, variant);
            var contentBuilder = new HtmlContentBuilder();
            TagBuilder input = InputGenerator.GeneratInput(id, name, value, fieldType, "mdc-text-field__input", required);
            
            contentBuilder.AppendLine(input);
            FieldGenerator.GenerateOutlineAndLabel(contentBuilder, id, label, variant, value);
            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }
    }
}
