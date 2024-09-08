namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Controllers.Options
{
    public class OptionsModelCache
    {
        private OptionsModel? model;
        public OptionsModel? Get()
        {
            return model;
        }
        public void Set(OptionsModel toSet)
        {
            model = toSet;
        }
    }
    }
