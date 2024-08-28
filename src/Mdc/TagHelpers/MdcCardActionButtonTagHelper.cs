using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

[HtmlTargetElement("mdc-card-action-button")]
public class MdcCardActionButtonTagHelper : TagHelper
{
    public required string Id { get; set; }
    public string? Label { get; set; }
    public bool Ripple { get; set; }
    public bool Touch { get; set; }
    public bool Disabled { get; set; }
    
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = ButtonGenerator.GenerateCardActionButton(Id, Label, Ripple, Touch, Disabled);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}