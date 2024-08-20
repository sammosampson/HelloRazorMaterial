namespace HelloRazorMaterial.Messages.Charts
{
    using HelloRazorMaterial.Abstractions;

    public record GetChartsViewDataResponse
    {
        public required IEnumerable<int> Data { get; init; }
        public required IEnumerable<string> Labels { get; init; }
        public required IEnumerable<string> Colours { get; init; }
        public required IEnumerable<Month> Months { get; init; }
    }
}
