using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using ObiletJourneyApp.Extensions;
using ObiletJourneyApp.Models;
using ObiletJourneyApp.Models.DTO;
using ObiletJourneyApp.Services;
using ObiletJourneyApp.Models.ViewModels; // Add this
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

    public async Task<IActionResult> Index(JourneySearchViewModel model)
    {
        if (!ModelState.IsValid)
        {
            // Optionally, return the same view with validation errors
            return BadRequest(ModelState);
        }

        if (model.DepartDate.Date < DateTime.Today)
        {
            ModelState.AddModelError(nameof(model.DepartDate), "Departure date cannot be in the past.");
            return BadRequest(ModelState);
        }

        var requestCulture = Request.HttpContext.Features.Get<IRequestCultureFeature>();
        GetBusJourneysRequest _request = new GetBusJourneysRequest
        {
            Date = model.DepartDate.ToString("yyyy-MM-dd"),
            Language = requestCulture?.RequestCulture.Culture.Name ?? _configuration["AppSettings:DefaultLanguage"] ?? "tr-TR",
            DeviceSession = HttpContext.Session.ToSessionInfo(),
            Data = new JourneyData
            {
                OriginId = model.OriginId,
                DestinationId = model.DestinationId,
                DepartureDate = model.DepartDate.ToString("yyyy-MM-dd")
            }
        };

        var journeys = await _obiletService.GetJourneys(_request);
        return View(journeys);
    }

}