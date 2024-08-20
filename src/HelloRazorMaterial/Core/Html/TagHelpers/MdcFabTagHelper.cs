namespace HelloRazorMaterial.Core.Html.TagHelpers
{
    using HelloRazorMaterial.Core.Html;
    using HelloRazorMaterial.Core.Html.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-fab")]
    public class MdcFabTagHelper : TagHelper
    {
        public required string Id { get; set; }
        public MdcFabType FabType { get; set; }
        public required string Icon { get; set; }
        public required string Label { get; set; }
        public bool Touch { get; set; }
        public bool Disabled { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = FabGenerator.GenerateFab(Id, FabType, Icon, Label, Touch, Disabled);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
