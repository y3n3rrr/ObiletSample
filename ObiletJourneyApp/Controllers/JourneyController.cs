using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using ObiletJourneyApp.Extensions;
using ObiletJourneyApp.Models;
using ObiletJourneyApp.Models.DTO;
using ObiletJourneyApp.Services;
using System.Reflection;

public class JourneyController : Controller
{
    private readonly IObiletService _obiletService;
    private readonly IConfiguration _configuration;

    public JourneyController(IObiletService obiletService, IConfiguration configuration)
    {
        _obiletService = obiletService;
        _configuration = configuration;
    }

    public async Task<IActionResult> Index(int originId, int destinationId, DateTime departDate)
    {
        var requestCulture = Request.HttpContext.Features.Get<IRequestCultureFeature>();
        GetBusJourneysRequest _request = new GetBusJourneysRequest
        {
            Date = departDate.ToString("yyyy-MM-dd"),
            Language = requestCulture?.RequestCulture.Culture.Name ?? _configuration["AppSettings:DefaultLanguage"] ?? "tr-TR",
            DeviceSession = HttpContext.Session.ToSessionInfo(),
            Data = new JourneyData
            {
                OriginId = originId,
                DestinationId = destinationId,
                DepartureDate = departDate.ToString("yyyy-MM-dd")
            }
        };

        var journeys = await _obiletService.GetJourneys(_request);
        return View(journeys);
    }

}