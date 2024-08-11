namespace HelloRazorMaterial.Controllers.Shared;

public record MenuItem    
{
    public required string Name { get; init; }
    public required string Icon { get; init; }
    public bool IsSelected { get; init; }
}