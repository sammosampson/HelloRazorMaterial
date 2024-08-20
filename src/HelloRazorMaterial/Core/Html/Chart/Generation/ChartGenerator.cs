namespace HelloRazorMaterial.Core.Html.Chart.Generation
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ChartGenerator
    {
        public static TagBuilder GenerateChart(string id)
        {
            var builder = new TagBuilder("canvas");
            builder.Attributes.Add("id", id);
            return builder;
        }
    }
}