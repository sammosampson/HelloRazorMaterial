namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Core
{
    using System.Text.Json;

    public static class ObjectExtensions
    {
        public static string ToJson(this object from)
        {
            return JsonSerializer.Serialize(from, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
    }
}
