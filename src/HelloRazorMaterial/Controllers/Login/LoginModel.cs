﻿namespace HelloRazorMaterial.Controllers.Login
{
    public record LoginModel
    {
        public required string Email { get; init; }
        public required string Password { get; init; }
    }
}