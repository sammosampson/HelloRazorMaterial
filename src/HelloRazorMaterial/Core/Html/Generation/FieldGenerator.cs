namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;

    public static class FieldGenerator
    {
        public static TagBuilder GenerateField(string id, string label, string? name, string? value, MdcFieldType fieldType, MdcVariant variant, bool required)
        {
            TagBuilder builder = GenerateFieldContainer(variant);
            var contentBuilder = new HtmlContentBuilder();
            contentBuilder.AppendLine(InputGenerator.GeneratInput(name, fieldType, "mdc-text-field__input", required));
            GenerateOutlineAndLabel(contentBuilder, id, label, variant);
            builder.InnerHtml.SetHtmlContent(contentBuilder);

            return builder;
        }

        private static TagBuilder GenerateFieldContainer(MdcVariant variant)
        {
            var builder = new TagBuilder("label");
            builder.AddCssClass("mdc-text-field");
            switch(variant)
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

        private static void GenerateOutlineAndLabel(HtmlContentBuilder content, string id, string label, MdcVariant variant)
        {
            switch (variant)
            {
                case MdcVariant.Outlined:
                    TagBuilder outlineBuilder = OutlineGenerator.GenerateNotchedOutline();
                    var outlineContentBuilder = new HtmlContentBuilder();
                    outlineContentBuilder.AppendLine(OutlineGenerator.GenerateNotchedOutlineLeading());
                    TagBuilder outlineNotchBuilder = OutlineGenerator.GenerateNotchedOutlineNotch();
                    outlineContentBuilder.AppendLine(outlineNotchBuilder);
                    outlineNotchBuilder.InnerHtml.SetHtmlContent(LabelGenerator.GenerateFloatingLabel(GetLabelId(id), label));
                    outlineContentBuilder.AppendLine(OutlineGenerator.GenerateNotchedOutlineTrailing());
                    outlineBuilder.InnerHtml.SetHtmlContent(outlineContentBuilder);
                    content.AppendLine(outlineBuilder);
                    break;
                case MdcVariant.Filled:
                    content.AppendLine(RippleGenerator.GenerateSelectRipple());
                    content.AppendLine(LabelGenerator.GenerateFloatingLabel(GetLabelId(id), label));
                    break;
            }
        }

        private static string GetLabelId(string id)
        {
            return $"{id}-field-label";
        }
    }
}
