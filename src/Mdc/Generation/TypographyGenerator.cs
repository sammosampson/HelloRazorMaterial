using Microsoft.AspNetCore.Mvc.Rendering;

namespace SystemDot.Web.Razor.Mdc.Generation
{
    public class TypographyGenerator
    {
        public static TagBuilder GenerateTypography(MdcTypographyType type, HtmlTag tag = HtmlTag.None) {
            if(tag == HtmlTag.None)
            {
                tag = GetHtmlTagForTypography(type);
            }
            var builder = new TagBuilder(tag!.ToString().ToLower());
            builder.AddCssClass($"mdc-typography--{GetCssExtensionsForTypography(type)}");
            return builder;
        }

        private static HtmlTag GetHtmlTagForTypography(MdcTypographyType type)
        {
            return type switch
            {
                MdcTypographyType.Headline1 => HtmlTag.H1,
                MdcTypographyType.Headline2 => HtmlTag.H2,
                MdcTypographyType.Headline3 => HtmlTag.H3,
                MdcTypographyType.Headline4 => HtmlTag.H4,
                MdcTypographyType.Headline5 => HtmlTag.H5,
                MdcTypographyType.Headline6 => HtmlTag.H6,
                MdcTypographyType.Subtitle1 => HtmlTag.P,
                MdcTypographyType.Subtitle2 => HtmlTag.P,
                MdcTypographyType.Body1 => HtmlTag.P,
                MdcTypographyType.Body2 => HtmlTag.P,
                MdcTypographyType.Button => HtmlTag.P,
                MdcTypographyType.Caption => HtmlTag.P,
                MdcTypographyType.Overline => HtmlTag.P,
                _ => throw new NotImplementedException(),
            };
        }

        private static string GetCssExtensionsForTypography(MdcTypographyType type)
        {
            return type switch
            {
                MdcTypographyType.Headline1 => "headline1",
                MdcTypographyType.Headline2 => "headline2",
                MdcTypographyType.Headline3 => "headline3",
                MdcTypographyType.Headline4 => "headline4",
                MdcTypographyType.Headline5 => "headline5",
                MdcTypographyType.Headline6 => "headline6",
                MdcTypographyType.Subtitle1 => "subtitle1",
                MdcTypographyType.Subtitle2 => "subtitle1",
                MdcTypographyType.Body1 => "body1",
                MdcTypographyType.Body2 => "body2",
                MdcTypographyType.Button => "button",
                MdcTypographyType.Caption => "caption",
                MdcTypographyType.Overline => "overline",
                _ => throw new NotImplementedException(),
            };
        }
    }
}