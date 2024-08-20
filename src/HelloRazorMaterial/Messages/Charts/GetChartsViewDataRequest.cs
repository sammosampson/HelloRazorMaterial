namespace HelloRazorMaterial.Messages.Charts
{
    using HelloRazorMaterial.Abstractions;
    using MediatR;

    public record GetChartsViewDataRequest : IRequest<GetChartsViewDataResponse>
    {
        public Month From { get; init; }
        public Month To { get; init; }
    }
}
