namespace HelloRazorMaterial.Core.Html.Chart
{
    public record ChartData
    {
        public IEnumerable<string>? Labels { get; init; }
        public required IEnumerable<ChartDataset> Datasets { get; init; }
    }
}
