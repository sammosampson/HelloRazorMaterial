using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation;

public class DataTableGenerator {
    public static TagBuilder GenerateTable()
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-data-table");
        return builder;
    }

    public static TagBuilder GenerateTableContainer()
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-data-table__table-container");
        return builder;
    }

    public static TagBuilder GenerateTableInner(string? label)
    {
        var builder = new TagBuilder("table");
        builder.AddCssClass("mdc-data-table__table");
        if (label is not null) {
            builder.Attributes.Add("aria-label", label);
        }

        return builder;
    }

    public static TagBuilder GenerateTableHeader()
    {
        return new TagBuilder("thead");
    }

    public static TagBuilder GenerateTableBody()
    {
        var builder = new TagBuilder("tbody");
        builder.AddCssClass("mdc-data-table__content");
        return builder;
    }

    public static TagBuilder GenerateTableHeaderRow() {
        var builder = new TagBuilder("tr");
        builder.AddCssClass("mdc-data-table__header-row");
        return builder;
    }

    public static TagBuilder GenerateTableBodyRow(bool selected)
    {
        var builder = new TagBuilder("tr");
        builder.AddCssClass("mdc-data-table__row");
        if(selected) {
            builder.AddCssClass("mdc-data-table__row--selected");
        }
        return builder;
    }

    public static TagBuilder GenerateTableHeaderCell(MdcCellType cellType)
    {
        var builder = new TagBuilder("th");
        builder.AddCssClass("mdc-data-table__header-cell");
        builder.Attributes.Add("role", "columnheader");
        builder.Attributes.Add("scope", "col");
        switch (cellType) {
            case MdcCellType.Numeric:
                builder.AddCssClass("mdc-data-table__header-cell--numeric");
                break;
        }
        return builder;
    }

    public static TagBuilder GenerateTableBodyCell(MdcCellType cellType)
    {
        var builder = new TagBuilder("td");
        AddTableCellClass(builder);
        AddCellTypeClass(cellType, builder);
        return builder;
    }

    public static TagBuilder GenerateTableBodyKeyCell(MdcCellType cellType)
    {
        var builder = new TagBuilder("th");
        AddTableCellClass(builder);
        builder.Attributes.Add("scope", "row");
        AddCellTypeClass(cellType, builder);
        return builder;
    }

    private static void AddTableCellClass(TagBuilder builder) {
        builder.AddCssClass("mdc-data-table__cell");
    }

    private static void AddCellTypeClass(MdcCellType cellType, TagBuilder builder) {
        switch (cellType)
        {
            case MdcCellType.Numeric:
                builder.AddCssClass("mdc-data-table__cell--numeric");
                break;
        }
    }
}