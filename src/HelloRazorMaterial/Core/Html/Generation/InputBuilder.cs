namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class InputBuilder
    {
        public static TagBuilder GeneratHiddenInput(string? id, string name)
        {
            var hiddenInputBuilder = new TagBuilder("input");
            hiddenInputBuilder.Attributes.Add("type", "hidden");
            hiddenInputBuilder.Attributes.Add("name", name);
            if (id != null)
            {
                hiddenInputBuilder.Attributes.Add("id", id);
            }
            return hiddenInputBuilder;
        }
    }
}
