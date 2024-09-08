namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Core.Html.Chart
{
    public record ChartConfig
    {
        public required string Type { get; init; }
        public required ChartData Data { get; init; }
    }
}
