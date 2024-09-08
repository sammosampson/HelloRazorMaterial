namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Tabs
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Shared;

    public record TabsModel : MenuModel
    {
        public int SelectedTab { get; init; }
    }
}