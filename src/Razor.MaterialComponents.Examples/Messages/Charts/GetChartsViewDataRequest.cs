namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Messages.Charts
{
    using SystemDot.Web.Razor.MaterialCompontents.Examples.Abstractions;
    using MediatR;

    public record GetChartsViewDataRequest : IRequest<GetChartsViewDataResponse>
    {
        public Month From { get; init; }
        public Month To { get; init; }
    }
}
