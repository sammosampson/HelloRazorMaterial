using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation;

public static class CardWrapperGenerator {
    public static TagBuilder GenerateTextSection() {
        var builder = new TagBuilder("div");

        builder.AddCssClass("mdc-card-wrapper__text-section");

        return builder;
    }
}