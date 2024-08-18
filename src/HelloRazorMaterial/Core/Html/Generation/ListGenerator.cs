namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class ListGenerator
    {
        public static TagBuilder GenerateList(IEnumerable<SelectListItem> options)
        {
            var listBuilder = new TagBuilder("ul");
            listBuilder.AddCssClass("mdc-list");
            listBuilder.Attributes.Add("role", "listbox");

            var listContentBuilder = new HtmlContentBuilder();
            listContentBuilder.AppendLine(GenerateListOption(true));
            foreach (SelectListItem option in options)
            {
                listContentBuilder.AppendLine(GenerateListOption(false, option.Value, option.Text));
            }
            listBuilder.InnerHtml.SetHtmlContent(listContentBuilder);
            return listBuilder;
        }

        public static IHtmlContent GenerateListOption(bool selected = false, string value = "", string text = "")
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

            var rippleBuilder = new TagBuilder("span");
            rippleBuilder.AddCssClass("mdc-list-item__ripple");
            listItemBuilder.InnerHtml.SetHtmlContent(rippleBuilder);

            if (text.Length > 0)
            {
                var textBuilder = new TagBuilder("span");
                textBuilder.AddCssClass("mdc-list-item__text");
                textBuilder.InnerHtml.SetContent(text);
                listItemBuilder.InnerHtml.SetHtmlContent(textBuilder);
            }

            return listItemBuilder;
        }
    }
}
