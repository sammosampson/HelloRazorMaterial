namespace HelloRazorMaterial.Controllers.Shared
{
    public record MenuModel {
        public required IEnumerable<MenuItem> Items { get; init; }
    }
}
