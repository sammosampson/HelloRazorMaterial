namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Core.Html.Chart.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ChartGenerator
    {
        public static TagBuilder GenerateChart(string id, ChartConfig config)
        {
            var builder = new TagBuilder("canvas");
            builder.Attributes.Add("id", id);
            builder.AddCssClass("chartjs-chart");
            builder.InnerHtml.SetHtmlContent(GenerateScript(id, config));
            return builder;
        }

        private static IHtmlContent GenerateScript(string id, ChartConfig config)
        {
            var builder = new TagBuilder("script");
            builder.Attributes.Add("id", $"{id}-chart-script");
            builder.Attributes.Add("type", "application/json");
            builder.InnerHtml.SetHtmlContent(config.ToJson());
            return builder;
        }
    }
}