namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Fields
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public record FieldsModel : MenuModel
    {
        public string? SelectValue { get; set; }
        public string? TextValue { get; set; }
        public string? EmailValue { get; set; }
        public string? PasswordValue { get; set; }
        public int? NumberValue { get; set; }
        public decimal? MoneyValue { get; set; }
        public TimeOnly? TimeValue { get; set; }
        public string? DateValue { get; set; }
        public string? LocalDateValue { get; set; }
        public string? TelephoneValue { get; set; }
        public string? TextAreaValue { get; set; }
        public IEnumerable<SelectListItem> Options { get; init; } = Enumerable.Empty<SelectListItem>();
    }
}