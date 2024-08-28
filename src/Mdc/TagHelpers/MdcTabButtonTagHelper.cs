using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

[HtmlTargetElement("mdc-tab-button")]
public class MdcTabButtonTagHelper : TagHelper
{
    public required string Id { get; set; }
    public string? Label { get; set; }
    public string? Name { get; set; }
    public string? Icon { get; set; }
    public int Index { get; set; }
    public bool Selected { get; set; }
    public bool Disabled { get; set; }
    
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = TabButtonGenerator.GenerateTabButton(Id, Name, Label, Icon, Index, Selected, Disabled);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}