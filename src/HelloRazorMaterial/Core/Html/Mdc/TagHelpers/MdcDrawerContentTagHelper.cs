namespace HelloRazorMaterial.Core.Html.Mdc.TagHelpers
{
    using HelloRazorMaterial.Core.Html.Mdc.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("mdc-drawer-content")]
    public class MdcDrawerContentTagHelper : TagHelper
    {
        public required string Id { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = DrawerGenerator.GenerateContent();
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}