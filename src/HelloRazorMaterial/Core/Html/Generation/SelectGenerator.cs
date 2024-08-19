namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class SelectGenerator
    {
        public static TagBuilder GenerateSelect(
            string id,
            string label,
            string? name, 
            string? value, 
            IEnumerable<SelectListItem>? items, 
            MdcVariant variant)
        {
            TagBuilder selectBuilder = GenerateSelectContainer(id, variant);
            var selectContentBuilder = new HtmlContentBuilder();

            if (name != null)
            {
                selectContentBuilder.AppendLine(InputGenerator.GeneratHiddenInput(name));
            }

            selectContentBuilder.AppendLine(GenerateSelectAnchor(id, label, variant));
            selectContentBuilder.AppendLine(GenerateSelectItems(items, value));

            selectBuilder.InnerHtml.SetHtmlContent(selectContentBuilder);
            return selectBuilder;
        }

        private static TagBuilder GenerateSelectContainer(string id, MdcVariant variant)
        {
            var selectBuilder = new TagBuilder("div");
            selectBuilder.AddCssClass("mdc-select");

            switch(variant)
            {
                case MdcVariant.Outlined:
                    selectBuilder.AddCssClass("mdc-select--outlined");
                    break;
                case MdcVariant.Filled:
                    selectBuilder.AddCssClass("mdc-select--filled");
                    break;
            }

            selectBuilder.Attributes.Add("id", id);
            

            return selectBuilder;
        }

        private static TagBuilder GenerateSelectAnchor(string id, string label, MdcVariant variant)
        {
            TagBuilder selectAnchorBuilder = GenerateSelectAnchorContainer(id);
            var selectAnchorContentBuilder = new HtmlContentBuilder();
            GenerateOutlineAndLabel(selectAnchorContentBuilder, id, label, variant);
            selectAnchorContentBuilder.AppendLine(GenerateSelectedTextContainer());
            selectAnchorContentBuilder.AppendLine(GenerateDropdownIcon());
            selectAnchorContentBuilder.AppendLine(RippleGenerator.GenerateLineRipple());

            selectAnchorBuilder.InnerHtml.SetHtmlContent(selectAnchorContentBuilder);
            return selectAnchorBuilder;
        }

        private static void GenerateOutlineAndLabel(HtmlContentBuilder selectAnchorContentBuilder, string id, string label, MdcVariant variant)
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
                    selectAnchorContentBuilder.AppendLine(outlineBuilder);
                    break;
                case MdcVariant.Filled:
                    selectAnchorContentBuilder.AppendLine(RippleGenerator.GenerateSelectRipple());
                    selectAnchorContentBuilder.AppendLine(LabelGenerator.GenerateFloatingLabel(GetLabelId(id), label));
                    break;
            }
        }

        private static TagBuilder GenerateSelectAnchorContainer(string id)
        {
            var selectAnchorBuilder = new TagBuilder("div");
            selectAnchorBuilder.AddCssClass("mdc-select__anchor");
            selectAnchorBuilder.Attributes.Add("role", "button");
            selectAnchorBuilder.Attributes.Add("aria-haspopup", "listbox");
            selectAnchorBuilder.Attributes.Add("aria-expanded", "false");
            selectAnchorBuilder.Attributes.Add("aria-labelledby", GetLabelId(id));
            return selectAnchorBuilder;
        }

        private static TagBuilder GenerateSelectedTextContainer()
        {
            var selectedTextContainerBuilder = new TagBuilder("span");
            selectedTextContainerBuilder.AddCssClass("mdc-select__selected-text-container");
            var selectedTextBuilder = new TagBuilder("span");
            selectedTextBuilder.AddCssClass("mdc-select__selected-text");
            selectedTextContainerBuilder.InnerHtml.SetHtmlContent(selectedTextBuilder);
            return selectedTextContainerBuilder;
        }

        private static TagBuilder GenerateDropdownIcon()
        {
            var iconBuilder = new TagBuilder("span");
            iconBuilder.AddCssClass("mdc-select__dropdown-icon");

            TagBuilder iconSvgBuilder = SvgGenerator.GenerateSvg("mdc-select__dropdown-icon-graphic", "7 10 10 5");
            var iconSvgContentBuilder = new HtmlContentBuilder();
            iconSvgContentBuilder.AppendLine(SvgGenerator.GenerateSvgPolygon("mdc-select__dropdown-icon-inactive", "7 10 12 15 17 10"));
            iconSvgContentBuilder.AppendLine(SvgGenerator.GenerateSvgPolygon("mdc-select__dropdown-icon-active", "7 15 12 10 17 15"));
            iconSvgBuilder.InnerHtml.SetHtmlContent(iconSvgContentBuilder);

            iconBuilder.InnerHtml.SetHtmlContent(iconSvgBuilder);
            return iconBuilder;
        }

        private static TagBuilder GenerateSelectItems(IEnumerable<SelectListItem>? items, string? selectedItem)
        {
            var selectMenuBuilder = new TagBuilder("div");
            selectMenuBuilder.AddCssClass("mdc-select__menu");
            selectMenuBuilder.AddCssClass("mdc-menu mdc-menu-surface");
            TagBuilder listBuilder = ListGenerator.GenerateList(items, selectedItem);

            selectMenuBuilder.InnerHtml.SetHtmlContent(listBuilder);
            return selectMenuBuilder;
        }

        private static string GetLabelId(string id)
        {
            return $"{id}-select-label";
        }
    }
}
