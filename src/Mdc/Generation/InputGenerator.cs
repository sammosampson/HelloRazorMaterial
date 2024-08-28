using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class InputGenerator
    {
        public static TagBuilder GeneratInput(string id, string? name, string? value, MdcFieldType fieldType, string? cssClass = null, bool required = false)
        {
            var hiddenInputBuilder = new TagBuilder("input");
            hiddenInputBuilder.Attributes.Add("id", id);
            hiddenInputBuilder.Attributes.Add("type", GetFieldTypeName(fieldType));

            if (name != null)
            {
                hiddenInputBuilder.Attributes.Add("name", name);
            }

            if (value != null)
            {
                hiddenInputBuilder.Attributes.Add("value", value);
            }

            if (cssClass != null)
            {
                hiddenInputBuilder.AddCssClass(cssClass);
            }

            if (required)
            {
                hiddenInputBuilder.Attributes.Add("required", "true");
            }

            return hiddenInputBuilder;
        }

        public static TagBuilder GeneratTextArea(string id, int rows, int cols, string? label, string? name, string? value, string? cssClass = null, bool required = false)
        {
            var hiddenInputBuilder = new TagBuilder("textarea");
            hiddenInputBuilder.Attributes.Add("id", id);
            hiddenInputBuilder.Attributes.Add("rows", rows.ToString());
            hiddenInputBuilder.Attributes.Add("cols", cols.ToString());

            if (name != null)
            {
                hiddenInputBuilder.Attributes.Add("name", name);
            }

            if (value != null)
            {
                hiddenInputBuilder.InnerHtml.SetContent(value);
            }

            if (cssClass != null)
            {
                hiddenInputBuilder.AddCssClass(cssClass);
            }

            if (label != null)
            {
                hiddenInputBuilder.Attributes.Add("aria-label", label);
            }

            if (required)
            {
                hiddenInputBuilder.Attributes.Add("required", "true");
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
                case MdcFieldType.Hidden:
                    return "hidden";
            }

            throw new NotImplementedException();
        }
    }
}
