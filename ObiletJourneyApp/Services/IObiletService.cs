using ObiletJourneyApp.Models.DTO;

public interface IObiletService
{
    Task<GetSessionResponse> GetSession(GetSessionRequest request);
    Task<GetBusLocationsResponse> GetBusLocations(GetBusLocationsRequest request);
    Task<GetBusJourneysResponse> GetJourneys(GetBusJourneysRequest request);
}