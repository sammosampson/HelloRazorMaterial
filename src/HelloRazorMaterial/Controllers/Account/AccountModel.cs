using HelloRazorMaterial.Controllers.Shared;

namespace HelloRazorMaterial.Controllers.Account
{
    public record AccountModel
    {
        public required string Email { get; init; }
        public required string Password { get; init; }
    }
}