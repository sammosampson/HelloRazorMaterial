using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public static class GridGenerator
    {
        public static TagBuilder GenerateGrid(bool fixedColumnWidth, MdcGridAlignment align)
        {
            var gridBuilder = new TagBuilder("div");
            gridBuilder.AddCssClass("mdc-layout-grid");
            if (fixedColumnWidth) 
            {
                gridBuilder.AddCssClass("mdc-layout-grid--fixed-column-width");
            }

            if (fixedColumnWidth) 
            {
                gridBuilder.AddCssClass($"mdc-layout-grid--align-{GetAlign(align)}");
            }

            return gridBuilder;
        }

        public static TagBuilder GenerateGridInner()
        {
            var gridInnerBuilder = new TagBuilder("div");
            gridInnerBuilder.AddCssClass("mdc-layout-grid__inner");

            return gridInnerBuilder;
        }

        private static string GetAlign(MdcGridAlignment align) {
            switch (align)
            {
                case MdcGridAlignment.Left: return "left";
                case MdcGridAlignment.Right: return "right";
                default: throw new NotImplementedException();
            };
        }

        public static TagBuilder GenerateCell(int span, int? index, MdcGridCellAlignment align)
        {
            var cellBuilder = new TagBuilder("div");
            cellBuilder.AddCssClass("mdc-layout-grid__cell");
            if (span > 0)
            {
                cellBuilder.AddCssClass($"mdc-layout-grid__cell--span-{span}");
            }
            if (align != MdcGridCellAlignment.None)
            {
                cellBuilder.AddCssClass($"mdc-layout-grid__cell--align-{GetAlign(align)}");
            }
            return cellBuilder;
        }

        private static string GetAlign(MdcGridCellAlignment align)
        {
            switch (align)
            {
                case MdcGridCellAlignment.Top: return "top";
                case MdcGridCellAlignment.Middle: return "middle";
                case MdcGridCellAlignment.Bottom: return "bottom";
                default: throw new NotImplementedException();
            };
        }
    }
}
