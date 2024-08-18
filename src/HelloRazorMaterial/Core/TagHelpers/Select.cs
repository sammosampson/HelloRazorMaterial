namespace HelloRazorMaterial.Core.TagHelpers
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-select")]
    public class MdcSelectTagHelper : TagHelper
    {
        public required string Label { get; set; }
        public required string Name { get; set; }
        public string? Id { get; set; }
        public bool FullWidth { get; set; } = true;
        public IEnumerable<SelectListItem> Options { get; set; } = new List<SelectListItem>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var classes = "mdc-select mdc-select--filled";
            if (FullWidth)
            {
                classes += " mdc-select--fullwidth";
            }

            output.Attributes.Add("class", classes);

            var optionsHtml = string.Empty;
            foreach (var option in Options)
            {
                optionsHtml += $"<li class='mdc-list-item' data-value='{option.Value}'><span class='mdc-list-item__ripple'></span><span class='mdc-list-item__text'>{option.Value}</span></li>";
            }

            output.Content.SetHtmlContent($@"
            <input type='hidden' name='{Name}' id='{Id ?? Name}' />
            <div 
                class='mdc-select__anchor'
                role='button'
                aria-haspopup='listbox'
                aria-expanded='false'>
                <span class='mdc-select__ripple'></span>
                <span class='mdc-floating-label'>{Label}</span>
                <span class='mdc-select__selected-text-container'>
                    <span class='mdc-select__selected-text'></span>
                </span>
                <span class='mdc-select__dropdown-icon'>
                    <svg
                        class='mdc-select__dropdown-icon-graphic'
                        viewBox='7 10 10 5'>
                        <polygon
                            class='mdc-select__dropdown-icon-inactive'
                            stroke='none'
                            fill-rule='evenodd'
                            points='7 10 12 15 17 10'>
                        </polygon>
                        <polygon
                            class='mdc-select__dropdown-icon-active'
                            stroke='none'
                            fill-rule='evenodd'
                            points='7 15 12 10 17 15'>
                        </polygon>
                    </svg>
                </span>
                <span class='mdc-line-ripple'></span>
            </div>

            <div class='mdc-select__menu mdc-menu mdc-menu-surface'>
                <ul class='mdc-list' role='listbox'>
                    <li class='mdc-list-item mdc-list-item--selected' aria-selected='true' data-value='' role='option'>
                        <span class='mdc-list-item__ripple'></span>
                    </li>
                    {optionsHtml}
                </ul>
            </div>
        ");
        }
    }

}
