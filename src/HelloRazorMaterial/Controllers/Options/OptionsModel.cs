namespace HelloRazorMaterial.Controllers.Options
{
    using HelloRazorMaterial.Controllers.Shared;

    public record OptionsModel : MenuModel
    {
        public bool CheckboxValue { get; set; }
    }
}