namespace HelloRazorMaterial.Controllers.Fields
{
    using HelloRazorMaterial.Controllers.Shared;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public record FieldsModel : MenuModel
    {
        public string? SelectValue { get; set; }
        public string? TextValue { get; set; }
        public string? TextAreaValue { get; set; }
        public IEnumerable<SelectListItem> Options { get; init; } = Enumerable.Empty<SelectListItem>();
    }
}