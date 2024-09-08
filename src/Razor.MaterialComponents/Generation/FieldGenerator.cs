using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.MaterialComponents.Generation
{
    public static class FieldGenerator
        {
            public static TagBuilder GenerateFormField()
            {
                var builder = new TagBuilder("div");
                builder.AddCssClass("mdc-form-field");
                return builder;
            }

            public static TagBuilder GenerateFieldContainer(string? label, MdcVariant variant)
        {
            var builder = new TagBuilder("label");
            if (label == null)
            {
                builder.AddCssClass("mdc-text-field--no-label");
            }
            builder.AddCssClass("mdc-text-field");
            switch (variant)
            {
                case MdcVariant.Outlined:
                    builder.AddCssClass("mdc-text-field--outlined");
                    break;
                case MdcVariant.Filled:
                    builder.AddCssClass("mdc-text-field--filled");
                    break;
            }
            return builder;
        }

        public static void GenerateOutlineAndLabel(HtmlContentBuilder content, string id, string? label, MdcVariant variant, string? value)
        {
            bool floatLabelAbove = value is not null;

            switch (variant)
            {
                case MdcVariant.Outlined:
                    TagBuilder outlineBuilder = OutlineGenerator.GenerateNotchedOutline();
                    var outlineContentBuilder = new HtmlContentBuilder();
                    outlineContentBuilder.AppendLine(OutlineGenerator.GenerateNotchedOutlineLeading());
                    if (label != null)
                    {
                        TagBuilder outlineNotchBuilder = OutlineGenerator.GenerateNotchedOutlineNotch();
                        outlineContentBuilder.AppendLine(outlineNotchBuilder);
                        outlineNotchBuilder.InnerHtml.SetHtmlContent(LabelGenerator.GenerateFloatingLabel(GetLabelId(id), label, floatLabelAbove));
                    }
                    outlineContentBuilder.AppendLine(OutlineGenerator.GenerateNotchedOutlineTrailing());
                    outlineBuilder.InnerHtml.SetHtmlContent(outlineContentBuilder);
                    content.AppendLine(outlineBuilder);
                    break;
                case MdcVariant.Filled:
                    content.AppendLine(RippleGenerator.GenerateSelectRipple());
                    if (label != null)
                    {
                        content.AppendLine(LabelGenerator.GenerateFloatingLabel(GetLabelId(id), label, floatLabelAbove));
                    }
                    break;
            }
        }

        public static string GetLabelId(string id)
        {
            return $"{id}-field-label";
        }
    }
}
