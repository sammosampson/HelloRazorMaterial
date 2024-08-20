namespace HelloRazorMaterial.Core.Html.Chart.TagHelpers
{
    using HelloRazorMaterial.Core.Html.Chart.Generation;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("chartjs-chart")]
    public class ChartJsChartTagHelper : TagHelper
    {
        public required string Id { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder builder = ChartGenerator.GenerateChart(Id);
            output.TagName = builder.TagName;
            output.MergeAttributes(builder);
            output.PostContent.AppendHtml(builder.InnerHtml);
        }
    }
}