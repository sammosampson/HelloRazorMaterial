using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class SelectGenerator
    {
        public static TagBuilder GenerateSelect(
            string id,
            string? label,
            string? name,
            string? value,
            IEnumerable<SelectListItem>? items,
            MdcVariant variant)
        {
            TagBuilder selectBuilder = GenerateSelectContainer(id, label, variant);
            var selectContentBuilder = new HtmlContentBuilder();

            if (name != null)
            {
                TagBuilder inputBuider = InputGenerator.GenerateInput(name, value, MdcFieldType.Hidden, Enumerable.Empty<string>());
                inputBuider.Attributes.Add("id", id);
                selectContentBuilder.AppendLine(inputBuider);
            }

            selectContentBuilder.AppendLine(GenerateSelectAnchor(id, label, variant, value));
            selectContentBuilder.AppendLine(GenerateSelectItems(items, value));

            selectBuilder.InnerHtml.SetHtmlContent(selectContentBuilder);
            return selectBuilder;
        }

        private static TagBuilder GenerateSelectContainer(string id, string? label, MdcVariant variant)
        {
            var selectBuilder = new TagBuilder("div");
            selectBuilder.AddCssClass("mdc-select");

            if(label is null)
            {

                selectBuilder.AddCssClass("mdc-select--no-label");

            }

            switch (variant)
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

        private static TagBuilder GenerateSelectAnchor(string id, string? label, MdcVariant variant, string? value)
        {
            TagBuilder selectAnchorBuilder = GenerateSelectAnchorContainer(id);
            var selectAnchorContentBuilder = new HtmlContentBuilder();
            FieldGenerator.GenerateOutlineAndLabel(selectAnchorContentBuilder, id, label, variant, value);
            selectAnchorContentBuilder.AppendLine(GenerateSelectedTextContainer());
            selectAnchorContentBuilder.AppendLine(IconGenerator.GenerateDropdownIcon());
            selectAnchorContentBuilder.AppendLine(RippleGenerator.GenerateLineRipple());

            selectAnchorBuilder.InnerHtml.SetHtmlContent(selectAnchorContentBuilder);
            return selectAnchorBuilder;
        }

        private static TagBuilder GenerateSelectAnchorContainer(string id)
        {
            var selectAnchorBuilder = new TagBuilder("div");
            selectAnchorBuilder.AddCssClass("mdc-select__anchor");
            selectAnchorBuilder.Attributes.Add("role", "button");
            selectAnchorBuilder.Attributes.Add("aria-haspopup", "listbox");
            selectAnchorBuilder.Attributes.Add("aria-expanded", "false");
            selectAnchorBuilder.Attributes.Add("aria-labelledby", FieldGenerator.GetLabelId(id));
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

        private static TagBuilder GenerateSelectItems(IEnumerable<SelectListItem>? items, string? selectedItem)
        {
            var selectMenuBuilder = new TagBuilder("div");
            selectMenuBuilder.AddCssClass("mdc-select__menu");
            selectMenuBuilder.AddCssClass("mdc-menu mdc-menu-surface");
            TagBuilder listBuilder = ListGenerator.GenerateList(items, selectedItem);

            selectMenuBuilder.InnerHtml.SetHtmlContent(listBuilder);
            return selectMenuBuilder;
        }
    }
}
