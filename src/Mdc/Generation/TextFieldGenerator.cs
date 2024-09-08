using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class TextFieldGenerator
    {
        public static TagBuilder GenerateTextField(string id, string? label, string? name, string? value, MdcFieldType fieldType, MdcVariant variant, string? prefix, string? suffix, string? cssClass, bool required)
        {
            TagBuilder builder = FieldGenerator.GenerateFieldContainer(label, variant);
            var contentBuilder = new HtmlContentBuilder();
            if (prefix is not null)
            {
                contentBuilder.AppendLine(GeneratePrefix(prefix));
            }

            var cssClasses = new List<string>()
            {
                "mdc-text-field__input"
            };

            if (cssClass is not null)
            {
                cssClasses.Add(cssClass);
            }

            TagBuilder inputBuilder = InputGenerator.GenerateInput(name, value, fieldType, cssClasses, required);
            inputBuilder.Attributes.Add("id", id);
            contentBuilder.AppendLine(inputBuilder);

            if (suffix is not null)
            {
                contentBuilder.AppendLine(GenerateSuffix(suffix));
            }
            FieldGenerator.GenerateOutlineAndLabel(contentBuilder, id, label, variant, value);
            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        private static TagBuilder GeneratePrefix(string prefix)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-text-field__affix");
            builder.AddCssClass("mdc-text-field__affix--prefix");
            builder.InnerHtml.SetContent(prefix);
            return builder;
        }

        private static TagBuilder GenerateSuffix(string suffix)
        {
            var builder = new TagBuilder("span");
            builder.AddCssClass("mdc-text-field__affix");
            builder.AddCssClass("mdc-text-field__affix--suffix");
            builder.InnerHtml.SetContent(suffix);
            return builder;
        }
    }
}
