using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SystemDot.Web.Razor.Mdc.Generation;

namespace SystemDot.Web.Razor.Mdc.TagHelpers;

[HtmlTargetElement("mdc-dialog")]
public class MdcDataDialogTagHelper : TagHelper
{
    public bool Open { get; set; }
    public MdcDialogType DialogType { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialog(Open, DialogType);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-container")]
public class MdcDataDialogContainerTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialogContainer();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-scrim")]
public class MdcDataDialogScrimTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialogScrim();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}


[HtmlTargetElement("mdc-dialog-actions")]
public class MdcDataDialogActionsTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialogActions();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-content")]
public class MdcDataDialogContentTagHelper : TagHelper
{
    public string Id { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialogContent(Id);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-header")]
public class MdcDataDialogHeaderTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialogHeader();
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-title")]
public class MdcDataDialogTitleTagHelper : TagHelper
{
    public string Id { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialogTitle(Id);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-surface")]
public class MdcDataDialogSurfaceTagHelper : TagHelper
{
    public string? LabelledBy { get; set; }
    public string? DescribedBy { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = DialogGenerator.GenerateDialogSurface(LabelledBy, DescribedBy);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-action-button")]
public class MdcDataDialogActionButtonTagHelper : TagHelper
{
    public string Id { get; set; }
    public string? Label { get; set; }
    public MdcActionType ActionType { get; set; }
    public bool Ripple { get; set; }
    public bool Default { get; set; }
    public bool Touch { get; set; }
    public bool Disabled { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = ButtonGenerator.GenerateDialogActionButton(Id, Label, ActionType, Default, Ripple, Touch, Disabled);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}

[HtmlTargetElement("mdc-dialog-header-close-button")]
public class MdcDataDialogHeaderCloseButtonTagHelper : TagHelper
{
    public string Id { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        TagBuilder builder = ButtonGenerator.GenerateDialogHeaderCloseButton(Id);
        output.TagName = builder.TagName;
        output.MergeAttributes(builder);
        output.PostContent.AppendHtml(builder.InnerHtml);
    }
}