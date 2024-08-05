namespace HelloRazorMaterial.Controllers.Shared
{
    public record MenuModel {
        public IEnumerable<MenuItem> Items { get; init; }
    }
}
