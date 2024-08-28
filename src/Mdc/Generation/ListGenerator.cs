using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class ListGenerator
    {
        public static TagBuilder GenerateList(IEnumerable<SelectListItem>? items, string? selectedItem)
        {
            items = items ?? Enumerable.Empty<SelectListItem>();

            TagBuilder listBuilder = GenerateListContainer();
            var listContentBuilder = new HtmlContentBuilder();

            if (string.IsNullOrEmpty(selectedItem))
            {
                var emptyItem = new SelectListItem { Text = string.Empty, Value = string.Empty, Selected = true };
                listContentBuilder.AppendLine(GenerateListItem(emptyItem));
            }

            foreach (SelectListItem item in items)
            {
                item.Selected = !item.Selected && selectedItem == item.Value;
                listContentBuilder.AppendLine(GenerateListItem(item));
            }

            listBuilder.InnerHtml.SetHtmlContent(listContentBuilder);

            return listBuilder;
        }

        private static TagBuilder GenerateListContainer()
        {
            var listBuilder = new TagBuilder("ul");
            listBuilder.AddCssClass("mdc-list");
            listBuilder.Attributes.Add("role", "listbox");
            return listBuilder;
        }

        public static IHtmlContent GenerateListItem(SelectListItem item)
        {
            TagBuilder listItemBuilder = GenerateListItemContainer(item);
            listItemBuilder.InnerHtml.SetHtmlContent(RippleGenerator.GenerateListItemRipple());

            if (!string.IsNullOrEmpty(item.Text))
            {
                GenerateListItemText(item.Text, listItemBuilder);
            }

            return listItemBuilder;
        }

        private static TagBuilder GenerateListItemContainer(SelectListItem item)
        {
            var listItemBuilder = new TagBuilder("li");
            listItemBuilder.AddCssClass("mdc-list-item");

            if (item.Selected)
            {
                listItemBuilder.AddCssClass("mdc-list-item--selected");
            }

            listItemBuilder.Attributes.Add("aria-selected", item.Selected.ToString().ToLower());
            listItemBuilder.Attributes.Add("data-value", item.Value);
            listItemBuilder.Attributes.Add("role", "option");

            return listItemBuilder;
        }

        private static void GenerateListItemText(string text, TagBuilder listItemBuilder)
        {
            var textBuilder = new TagBuilder("span");
            textBuilder.AddCssClass("mdc-list-item__text");
            textBuilder.InnerHtml.SetContent(text);
            listItemBuilder.InnerHtml.SetHtmlContent(textBuilder);
        }
    }
}
