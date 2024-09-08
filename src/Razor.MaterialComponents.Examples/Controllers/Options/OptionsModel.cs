namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Options
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

    public record OptionsModel : MenuModel
    {
        public bool CheckboxValue { get; set; }
    }
}