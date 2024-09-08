using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class TextAreaGenerator
    {
        public static TagBuilder GenerateTextArea(string id, int rows, int cols, string? label, string? name, string? value, MdcVariant variant, bool required)
        {
            TagBuilder builder = FieldGenerator.GenerateFieldContainer(label, variant);
            builder.AddCssClass("mdc-text-field--textarea");
            var contentBuilder = new HtmlContentBuilder();
            FieldGenerator.GenerateOutlineAndLabel(contentBuilder, id, label, variant, value);
            contentBuilder.AppendLine(GenerateResizableInput(id, rows, cols, label, name, value, required));
            builder.InnerHtml.SetHtmlContent(contentBuilder);
            return builder;
        }

        private static TagBuilder GenerateResizableInput(string id, int rows, int cols, string? label, string? name, string? value, bool required)
        {
            TagBuilder builder = new TagBuilder("span");
            builder.AddCssClass("mdc-text-field__resizer");
            builder.InnerHtml.SetHtmlContent(InputGenerator.GeneratTextArea(id, rows, cols, label, name, value, required));
            return builder;
        }
    }           
}
