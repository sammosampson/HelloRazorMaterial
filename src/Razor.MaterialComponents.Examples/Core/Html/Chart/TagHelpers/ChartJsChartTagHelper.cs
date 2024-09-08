namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Core.Html.Chart.TagHelpers
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Core.Html.Chart.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("chartjs-chart")]
    public class ChartJsChartTagHelper : TagHelper
    {
        public required string Id { get; set; }
        
        public required ChartConfig Config { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = ChartGenerator.GenerateChart(Id, Config);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}