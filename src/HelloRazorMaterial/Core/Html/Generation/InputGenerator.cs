namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class InputGenerator
    {
        public static TagBuilder GeneratHiddenInput(string name)
        {
            var hiddenInputBuilder = new TagBuilder("input");
            hiddenInputBuilder.Attributes.Add("type", "hidden");
            hiddenInputBuilder.Attributes.Add("name", name);
            return hiddenInputBuilder;
        }
    }
}
