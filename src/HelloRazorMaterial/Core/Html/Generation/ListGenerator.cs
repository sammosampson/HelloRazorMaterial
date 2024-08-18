namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class ListGenerator
    {
        public static TagBuilder GenerateList(IEnumerable<SelectListItem> options)
        {
            TagBuilder listBuilder = GenerateListContainer();
            var listContentBuilder = new HtmlContentBuilder();

            listContentBuilder.AppendLine(GenerateListItem(true));
            
            foreach (SelectListItem option in options)
            {
                listContentBuilder.AppendLine(GenerateListItem(false, option.Value, option.Text));
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

        public static IHtmlContent GenerateListItem(bool selected = false, string value = "", string text = "")
        {
            TagBuilder listItemBuilder = GenerateListItemContainer(selected, value);
            listItemBuilder.InnerHtml.SetHtmlContent(RippleGenerator.GenerateListItemRipple());

            if (text.Length > 0)
            {
                GenerateListItemText(text, listItemBuilder);
            }

            return listItemBuilder;
        }

        private static TagBuilder GenerateListItemContainer(bool selected, string value)
        {
            var listItemBuilder = new TagBuilder("li");
            listItemBuilder.AddCssClass("mdc-list-item");
            
            if (selected)
            {
                listItemBuilder.AddCssClass("mdc-list-item--selected");
            }

            listItemBuilder.Attributes.Add("aria-selected", selected.ToString().ToLower());
            listItemBuilder.Attributes.Add("data-value", value);
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
