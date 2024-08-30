using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation;

public class DialogGenerator {
    public static TagBuilder GenerateDialog(bool open, MdcDialogType dialogType)
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-dialog");
        
        if (open) {
            builder.AddCssClass("mdc-dialog--open");
        }

        switch (dialogType) {
            case MdcDialogType.FullScreen:
                builder.AddCssClass("mdc-dialog--fullscreen");
                break;
        }
            
        return builder;
    }

    public static TagBuilder GenerateDialogContainer() 
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-dialog__container");
        return builder;
    }

    public static TagBuilder GenerateDialogScrim()
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-dialog__scrim");
        return builder;
    }

    public static TagBuilder GenerateDialogActions()
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-dialog__actions");
        return builder;
    }

    public static TagBuilder GenerateDialogContent(string id)
    {
        var builder = new TagBuilder("div");
        builder.Attributes.Add("id", id);
        builder.AddCssClass("mdc-dialog__content");
        return builder;
    }

    public static TagBuilder GenerateDialogHeader()
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-dialog__header");
        return builder;
    }

    public static TagBuilder GenerateDialogTitle(string id)
    {
        var builder = new TagBuilder("h2");
        builder.Attributes.Add("id", id);
        builder.AddCssClass("mdc-dialog__title");
        return builder;
    }

    public static TagBuilder GenerateDialogSurface(string? labelledBy, string? describedBy)
    {
        var builder = new TagBuilder("div");
        builder.AddCssClass("mdc-dialog__surface");
        builder.Attributes.Add("role", "dialog");
        builder.Attributes.Add("aria-modal", "true");
        if (labelledBy != null) 
        {
            builder.Attributes.Add("aria-labelledby", labelledBy);
        }

        if (describedBy != null) 
        {
            builder.Attributes.Add("aria-describedBy", describedBy);
        }

        return builder;
    }
}