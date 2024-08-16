namespace HelloRazorMaterial.Controllers.Charts
{
    using HelloRazorMaterial.Controllers.Shared;

    public record ChartsModel : MenuModel
    {
        public required int[] Data { get; init; }
        public required string[] Labels { get; init; }
        public required string[] Colours { get; init; }
    }
}
