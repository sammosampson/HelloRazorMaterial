namespace HelloRazorMaterial.Core.Html.Chart
{
    public record ChartDataset
    {
        public string? Label { get; init; }
        public required IEnumerable<int> Data { get; init; }
        public IEnumerable<string>? BackgroundColor { get; init; }
        public int HoverOffset { get; init; }
    }
}
