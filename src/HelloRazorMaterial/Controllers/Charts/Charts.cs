namespace HelloRazorMaterial.Controllers.Charts
{
    using HelloRazorMaterial.Abstractions;
    using HelloRazorMaterial.Messages.Charts;
    using MediatR;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Threading.Tasks;

    [Authorize]
    public class Charts : Controller
    {
        private readonly ISender sender;

        public Charts(ISender sender)
        {
            this.sender = sender;
        }

        public async Task<IActionResult> IndexAsync(Month from = Month.January, Month to = Month.December)
        {
            GetChartsViewDataResponse response = await sender.Send(
                new GetChartsViewDataRequest
                {
                    From = from,
                    To = to,
                });

            return View(
                new ChartsModel
                {
                    Data = response.Data,
                    Months = response.Months.Select(m => new SelectListItem { Text = Enum.GetName(m), Value = m.ToString() }),
                    From = from.ToString(),
                    To = to.ToString(),
                    Labels = response.Labels,
                    Colours = response.Colours,
                    ControllerName = nameof(Charts)
                }
            );
        }
    }
}
