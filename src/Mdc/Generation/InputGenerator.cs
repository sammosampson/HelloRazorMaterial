using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class InputGenerator
    {
        public static TagBuilder GeneratTextArea(string id, int rows, int cols, string? label, string? name, string? value, bool required = false)
        {
            var builder = new TagBuilder("textarea");
            builder.Attributes.Add("id", id);
            builder.Attributes.Add("rows", rows.ToString());
            builder.Attributes.Add("cols", cols.ToString());

            if (name != null)
            {
                builder.Attributes.Add("name", name);
            }

            if (value != null)
            {
                builder.InnerHtml.SetContent(value);
            }

            builder.AddCssClass("mdc-text-field__input");

            if (label != null)
            {
                builder.Attributes.Add("aria-label", label);
            }

            if (required)
            {
                builder.Attributes.Add("required", "true");
            }

            return builder;
        }

        public static TagBuilder GenerateCheckbox(ModelExpression? @for)
        {
            TagBuilder tagBuilder = GenerateInput(MdcFieldType.Checkbox, ["mdc-checkbox__native-control"]);

            if (@for is not null)
            {
                tagBuilder.Attributes.Add("name", @for!.Name);
                tagBuilder.Attributes.Add("value", "true");

                bool isChecked = (bool)@for.Model;
                if (isChecked)
                {
                    tagBuilder.Attributes.Add("checked", "");
                }
            }

            return tagBuilder;
        }

        public static TagBuilder GenerateInput(string? name, string? value, MdcFieldType fieldType, IEnumerable<string> cssClasses, bool required = false)
        {
            TagBuilder inputBuilder = GenerateInput(fieldType, cssClasses);

            if (name != null)
            {
                inputBuilder.Attributes.Add("name", name);
            }

            if (value != null)
            {
                inputBuilder.Attributes.Add("value", value);
            }

            if (required)
            {
                inputBuilder.Attributes.Add("required", "true");
            }

            return inputBuilder;
        }

        private static TagBuilder GenerateInput(MdcFieldType fieldType, IEnumerable<string> cssClasses)
        {
            var hiddenInputBuilder = new TagBuilder("input");
            hiddenInputBuilder.Attributes.Add("type", GetFieldTypeName(fieldType));

            foreach (string cssClass in cssClasses)
            {
                hiddenInputBuilder.AddCssClass(cssClass);
            }

            return hiddenInputBuilder;
        }

        private static string? GetFieldTypeName(MdcFieldType fieldType)
        {
            switch (fieldType)
            {
                case MdcFieldType.Text:
                    return "text";
                case MdcFieldType.Email:
                    return "email";
                case MdcFieldType.Password:
                    return "password";
                case MdcFieldType.Number:
                    return "number";
                case MdcFieldType.Time:
                    return "time";
                case MdcFieldType.Date:
                    return "date";
                case MdcFieldType.LocalDate:
                    return "datetime-local";
                case MdcFieldType.Telephone:
                    return "tel";
                case MdcFieldType.Checkbox:
                    return "checkbox";
                case MdcFieldType.Hidden:
                    return "hidden";
            }

            throw new NotImplementedException();
        }
    }
}
