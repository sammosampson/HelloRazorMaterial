namespace HelloRazorMaterial.Pipeline.Charts
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using HelloRazorMaterial.Messages.Charts;
    using HelloRazorMaterial.Abstractions;

    public class GetChartsViewDataRequestHandler : IRequestHandler<GetChartsViewDataRequest, GetChartsViewDataResponse>
    {
        public Task<GetChartsViewDataResponse> Handle(GetChartsViewDataRequest request, CancellationToken cancellationToken)
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

            var response = new GetChartsViewDataResponse
            {
                Data =
                [
                    GetSummedColourValue(data, Colour.Red, request.From, request.To),
                    GetSummedColourValue(data, Colour.Blue, request.From, request.To),
                    GetSummedColourValue(data, Colour.Yellow, request.From, request.To)
                ],
                Months = months,
                Labels = colours.Select(c => c.Name).ToArray(),
                Colours = colours.Select(c => c.ToRgbValue()).ToArray()
            };

            return Task.FromResult(response);
        }

        private static int GetSummedColourValue(IEnumerable<ColourData> data, Colour colour, Month from, Month to)
        {
            return data
                .Where(d => d.Colour == colour && (int)d.Month >= (int)from && (int)d.Month <= (int)to)
                .Sum(c => c.Value);
        }
    }
}
