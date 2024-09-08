namespace SystemDot.Web.Razor.MaterialComponents.Examples.Views.Shared
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Core.Html.Chart;

    public static class BestColoursChartConfigBuilder
    {
        public static ChartConfig Build(string type, IEnumerable<string> labels, IEnumerable<string> colours, IEnumerable<int> data)
        {
            return new ChartConfig
            {
                Type = type,
                Data = new ChartData
                {
                    Labels = labels,
                    Datasets =
                    [
                        new ChartDataset
                        {
                            Label = "Best colours",
                            Data = data,
                            BackgroundColor = colours,
                            HoverOffset = 4
                        }
                    ]
                }
            };
        }
    }
}
