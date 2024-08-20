namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;

    public static class GridGenerator
    {
        public static TagBuilder GenerateGrid()
        {
            var gridBuilder = new TagBuilder("div");
            gridBuilder.AddCssClass("mdc-layout-grid");
            
            return gridBuilder;
        }

        public static TagBuilder GenerateGridInner()
        {
            var gridInnerBuilder = new TagBuilder("div");
            gridInnerBuilder.AddCssClass("mdc-layout-grid__inner");
            
            return gridInnerBuilder;
        }

        public static TagBuilder GenerateCell(int span)
        {
            var cellBuilder = new TagBuilder("div");
            cellBuilder.AddCssClass("mdc-layout-grid__cell");
            if (span > 0)
            {
                cellBuilder.AddCssClass($"mdc-layout-grid__cell--span-{span}");
            }
            return cellBuilder;
        }
    }
}
