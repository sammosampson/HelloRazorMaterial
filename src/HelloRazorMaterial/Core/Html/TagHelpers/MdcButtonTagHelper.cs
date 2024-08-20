namespace HelloRazorMaterial.Core.Html.TagHelpers
{
    using HelloRazorMaterial.Core.Html;
    using HelloRazorMaterial.Core.Html.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-button")]
    public class MdcButtonTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public string? Label { get; set; }
        public MdcButtonType ButtonType { get; set; }
        public MdcIconType IconType { get; set; }
        public string? Icon { get; set; }
        public bool Ripple { get; set; }
        public bool FocusRing { get; set; }
        public bool Touch { get; set; }
        public bool Disabled { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = ButtonGenerator.GenerateButton(Id, Label, ButtonType, IconType, Icon, Ripple, FocusRing, Touch, Disabled);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
