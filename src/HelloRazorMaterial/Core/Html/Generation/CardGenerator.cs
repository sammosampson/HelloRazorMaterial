﻿namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    public static class CardGenerator
    {
        public static TagBuilder GenerateCard()
        {
            var gridBuilder = new TagBuilder("div");
            gridBuilder.AddCssClass("mdc-card");

            return gridBuilder;
        }
    }
}
