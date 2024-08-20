namespace HelloRazorMaterial.Core.Html.Generation
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;

    public static class InputGenerator
    {
        public static TagBuilder GeneratInput(string? name, MdcFieldType fieldType, string? cssClass = null, bool required = false)
        {
            var hiddenInputBuilder = new TagBuilder("input");
            hiddenInputBuilder.Attributes.Add("type", GetFieldTypeName(fieldType));

            if(name != null) 
            { 
                hiddenInputBuilder.Attributes.Add("name", name);
            }

            if (cssClass != null)
            {
                hiddenInputBuilder.AddCssClass(cssClass);
            }

            if (required)
            {
                hiddenInputBuilder.Attributes.Add("required", "true");
            }
            
            return hiddenInputBuilder;
        }

        private static string? GetFieldTypeName(MdcFieldType fieldType)
        {
            switch(fieldType)
            {
                case MdcFieldType.Text:
                    return "text";
                case MdcFieldType.Email:
                    return "email";
                case MdcFieldType.Password:
                    return "password";
                case MdcFieldType.Hidden:
                    return "hidden";
            }

            throw new NotImplementedException();
        }
    }
}
