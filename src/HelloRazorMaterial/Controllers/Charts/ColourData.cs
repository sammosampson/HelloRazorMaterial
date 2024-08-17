namespace HelloRazorMaterial.Controllers.Charts
{
    public record ColourData
    {
        public required Colour Colour { get; init; }
        public required Month Month { get; init; }
        public required int Value { get; init; }
    }
}
