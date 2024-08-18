namespace HelloRazorMaterial.Controllers.Charts
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    [Authorize]
    public class Charts : Controller
    {
        public IActionResult Index(Month from = Month.January, Month to = Month.December)
        {
            IEnumerable<Colour> colours = [Colour.Red, Colour.Blue, Colour.Yellow];

            IEnumerable<Month> months = [
                Month.January,
                Month.February,
                Month.March,
                Month.April,
                Month.May,
                Month.June,
                Month.July,
                Month.August,
                Month.September,
                Month.October,
                Month.November,
                Month.December];

            IEnumerable<ColourData> data = [
                new ColourData { Colour = Colour.Red, Month = Month.January, Value = 300 },
                new ColourData { Colour = Colour.Blue, Month = Month.February, Value = 50 },
                new ColourData { Colour = Colour.Yellow, Month = Month.March, Value = 100 },
                new ColourData { Colour = Colour.Red, Month = Month.April, Value = 300 },
                new ColourData { Colour = Colour.Blue, Month = Month.May, Value = 50 },
                new ColourData { Colour = Colour.Yellow, Month = Month.June, Value = 100 },
                new ColourData { Colour = Colour.Yellow, Month = Month.July, Value = 100 },
                new ColourData { Colour = Colour.Blue, Month = Month.July, Value = 100 },
                new ColourData { Colour = Colour.Red, Month = Month.August, Value = 50 },
                new ColourData { Colour = Colour.Red, Month = Month.July, Value = 100 },
                new ColourData { Colour = Colour.Blue, Month = Month.September, Value = 100 },
                new ColourData { Colour = Colour.Red, Month = Month.October, Value = 50 },
                new ColourData { Colour = Colour.Red, Month = Month.November, Value = 100 },
                new ColourData { Colour = Colour.Yellow, Month = Month.December, Value = 100 },
                new ColourData { Colour = Colour.Red, Month = Month.December, Value = 50 },
                new ColourData { Colour = Colour.Yellow, Month = Month.December, Value = 100 }
            ];

            return base.View(
                new ChartsModel
                {
                    Data = 
                    [ 
                        GetSummedColourValue(data, Colour.Red, from, to), 
                        GetSummedColourValue(data, Colour.Blue, from, to), 
                        GetSummedColourValue(data, Colour.Yellow, from, to)
                    ],
                    Months = months.Select(m => new SelectListItem { Text = Enum.GetName(m), Value = m.ToString() }),
                    From = from.ToString(),
                    To = to.ToString(),
                    Labels = colours.Select(c => c.Name).ToArray(),
                    Colours = colours.Select(c => c.ToRgbValue()).ToArray(),
                    ControllerName = nameof(Charts)
                }
            );
        }

        private static int GetSummedColourValue(IEnumerable<ColourData> data, Colour colour, Month from, Month to)
        {
            return data
                .Where(d => d.Colour == colour && (int)d.Month >= (int)from && (int)d.Month <= (int)to)
                .Sum(c => c.Value);
        }
    }
}
