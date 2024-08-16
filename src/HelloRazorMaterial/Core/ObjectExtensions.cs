﻿namespace HelloRazorMaterial.Core
{
    using System.Text.Json;

    public static class ObjectExtensions
    {
        public static string ToJson(this object from)
        {
            return JsonSerializer.Serialize(from);
        }
    }
}
