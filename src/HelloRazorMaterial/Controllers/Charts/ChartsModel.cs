namespace HelloRazorMaterial.Controllers.Charts
{
    using HelloRazorMaterial.Controllers.Shared;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public record ChartsModel : MenuModel
    {
        public required IEnumerable<int> Data { get; init; }
        public required IEnumerable<string> Labels { get; init; }
        public required IEnumerable<string> Colours { get; init; }
        public required IEnumerable<SelectListItem> Months { get; init; }
        public required string From { get; init; }
        public required string To { get; init; }
    }
}
