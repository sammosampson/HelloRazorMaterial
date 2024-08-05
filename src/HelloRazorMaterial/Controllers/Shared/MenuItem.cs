namespace HelloRazorMaterial.Controllers.Shared;

public record MenuItem    
{
    public string Name { get; init; }
    public string Icon { get; init; }
    public bool IsSelected { get; init; }
}