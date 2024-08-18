namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class SelectGenerator
    {
        public static TagBuilder GenerateSelect(string? id, string name, string label, bool fullWidth, IEnumerable<SelectListItem> options)
        {
            TagBuilder selectBuilder = GenerateSelectContainer(fullWidth);
            var selectContentBuilder = new HtmlContentBuilder();

            selectContentBuilder.AppendLine(InputBuilder.GeneratHiddenInput(id, name));
            selectContentBuilder.AppendLine(GenerateSelectAnchor(label));
            selectContentBuilder.AppendLine(GenerateSelectOptions(options));

            selectBuilder.InnerHtml.SetHtmlContent(selectContentBuilder);
            return selectBuilder;
        }

        private static TagBuilder GenerateSelectContainer(bool fullWidth)
        {
            var selectBuilder = new TagBuilder("div");
            selectBuilder.AddCssClass("mdc-select");
            selectBuilder.AddCssClass("mdc-select--filled");
            if (fullWidth)
            {
                selectBuilder.AddCssClass("mdc-select--fullwidth");
            }

            return selectBuilder;
        }

        private static TagBuilder GenerateSelectAnchor(string label)
        {
            TagBuilder selectAnchorBuilder = GenerateSelectAnchorContainer();
            var selectAnchorContentBuilder = new HtmlContentBuilder();

            selectAnchorContentBuilder.AppendLine(RippleBuilder.GenerateSelectRipple());
            selectAnchorContentBuilder.AppendLine(LabelBuilder.GenerateFloatingLabel(label));
            selectAnchorContentBuilder.AppendLine(GenerateSelectedTextContainer());
            selectAnchorContentBuilder.AppendLine(GenerateDropdownIcon());
            selectAnchorContentBuilder.AppendLine(RippleBuilder.GenerateLineRipple());

            selectAnchorBuilder.InnerHtml.SetHtmlContent(selectAnchorContentBuilder);
            return selectAnchorBuilder;
        }

        private static TagBuilder GenerateSelectAnchorContainer()
        {
            var selectAnchorBuilder = new TagBuilder("div");
            selectAnchorBuilder.AddCssClass("mdc-select__anchor");
            selectAnchorBuilder.Attributes.Add("role", "button");
            selectAnchorBuilder.Attributes.Add("aria-haspopup", "listbox");
            selectAnchorBuilder.Attributes.Add("aria-expanded", "false");
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

            TagBuilder iconSvgBuilder = SvgBuilder.GenerateSvg("mdc-select__dropdown-icon-graphic", "7 10 10 5");
            var iconSvgContentBuilder = new HtmlContentBuilder();
            iconSvgContentBuilder.AppendLine(SvgBuilder.GenerateSvgPolygon("mdc-select__dropdown-icon-inactive", "7 10 12 15 17 10"));
            iconSvgContentBuilder.AppendLine(SvgBuilder.GenerateSvgPolygon("mdc-select__dropdown-icon-active", "7 15 12 10 17 15"));
            iconSvgBuilder.InnerHtml.SetHtmlContent(iconSvgContentBuilder);

            iconBuilder.InnerHtml.SetHtmlContent(iconSvgBuilder);
            return iconBuilder;
        }

        private static TagBuilder GenerateSelectOptions(IEnumerable<SelectListItem> options)
        {
            var selectMenuBuilder = new TagBuilder("div");
            selectMenuBuilder.AddCssClass("mdc-select__menu");
            selectMenuBuilder.AddCssClass("mdc-menu mdc-menu-surface");
            TagBuilder listBuilder = ListGenerator.GenerateList(options);

            selectMenuBuilder.InnerHtml.SetHtmlContent(listBuilder);
            return selectMenuBuilder;
        }
    }
}
