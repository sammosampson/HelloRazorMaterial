using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers
{
    [HtmlTargetElement("mdc-card")]
    public class MdcCardTagHelper : TagHelper
    {
        public MdcCardType CardType { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = CardGenerator.GenerateCard(CardType);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}
