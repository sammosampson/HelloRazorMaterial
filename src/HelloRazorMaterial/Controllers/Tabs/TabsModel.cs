namespace HelloRazorMaterial.Controllers.Tabs
{
    using HelloRazorMaterial.Controllers.Shared;

    public record TabsModel : MenuModel
    {
        public int SelectedTab { get; init; }
    }
}