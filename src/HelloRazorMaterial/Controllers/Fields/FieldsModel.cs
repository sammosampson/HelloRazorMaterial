namespace HelloRazorMaterial.Controllers.Fields
{
    using HelloRazorMaterial.Controllers.Shared;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public record FieldsModel : MenuModel
    {
        public required IEnumerable<SelectListItem> Options { get; init; }
    }
}