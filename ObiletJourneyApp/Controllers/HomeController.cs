using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using ObiletJourneyApp.Extensions;
using ObiletJourneyApp.Models;
using ObiletJourneyApp.Models.DTO;
using ObiletJourneyApp.Services;
using System.Reflection;

public class HomeController : Controller
{
    private readonly IObiletService _obiletService;
    private readonly IConfiguration _configuration;
    public HomeController(IConfiguration configuration, IObiletService obiletService)
    {
        _configuration = configuration;
        _obiletService = obiletService;
    }

    public async Task<IActionResult> Index(int? originId, int? destinationId, DateTime? departDate)
    {
        var session = await _obiletService.GetSession(HttpContext.ToGetSessionDto());
        HttpContext.Session.SetString("SessionId", session.Data.SessionId);
        HttpContext.Session.SetString("DeviceId", session.Data.DeviceId);

        var requestCulture = Request.HttpContext.Features.Get<IRequestCultureFeature>();
        GetBusLocationsRequest _request = new GetBusLocationsRequest { 
            Date = DateTime.Today.AddDays(1),
            Language = requestCulture?.RequestCulture.Culture.Name ?? _configuration["AppSettings:DefaultLanguage"] ?? "tr-TR",
            DeviceSession = HttpContext.Session.ToSessionInfo()
        };
        var origins = await _obiletService.GetBusLocations(_request);
        var dests = await _obiletService.GetBusLocations(_request);

        var model = new SearchViewModel
        {
            OriginId = originId,
            DestinationId = destinationId,
            Origins = origins.Data,
            Destinations = dests.Data,
            DepartDate = departDate ?? DateTime.Today.AddDays(1)
        };
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Search(SearchViewModel model)
    {
        if (model.OriginId == model.DestinationId)
            ModelState.AddModelError("", "Origin and destination cannot be same");
        if (model.DepartDate.Date < DateTime.Today)
            ModelState.AddModelError("", "Departure date cannot be in the past");

        if (!ModelState.IsValid)
        {
            var session = await _obiletService.GetSession(HttpContext.ToGetSessionDto());
            var requestCulture = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            GetBusLocationsRequest _request = new GetBusLocationsRequest
            {
                Date = DateTime.Today.AddDays(11),
                Language = requestCulture?.RequestCulture.Culture.Name ?? _configuration["AppSettings:DefaultLanguage"] ?? "tr-TR",
                DeviceSession = HttpContext.Session.ToSessionInfo()
            };

            model.Origins = (await _obiletService.GetBusLocations(_request)).Data;
            model.Destinations = (await _obiletService.GetBusLocations(_request)).Data;

            return View("Index", model);
        }

        return RedirectToAction("Index", "Journey", new {
            originId = model.OriginId,
            destinationId = model.DestinationId,
            departDate = model.DepartDate.ToString("yyyy-MM-dd")
        });
    }
}