using ObiletJourneyApp.Models;
using ObiletJourneyApp.Models.DTO;

namespace ObiletJourneyApp.Services
{
    public class ObiletApiClient : IObiletService
    {
        private readonly HttpClient _http;
        private readonly string _token;

        // Define DefaultSession as a private readonly field

        public ObiletApiClient(HttpClient http, IConfiguration cfg)
        {
            _http = http;
            _token = cfg["ObiletApi:ClientToken"] ?? throw new Exception("Token not found");
            _http.DefaultRequestHeaders.Authorization = new("Basic", _token);
        }

        public async Task<GetSessionResponse> GetSession(GetSessionRequest _request)
            => await CallApi<GetSessionResponse>("client/GetSession", _request);

        public async Task<GetBusLocationsResponse> GetBusLocations(GetBusLocationsRequest _request)
        {
            var response = await CallApi<GetBusLocationsResponse>("location/GetBusLocations", _request);
            return response;
        }

        public async Task<GetBusJourneysResponse> GetJourneys(GetBusJourneysRequest _request)
        {
            var response = await CallApi<GetBusJourneysResponse>("journey/getbusjourneys", _request);
            return response;
        }

        // Generic POST helper
        private async Task<T> CallApi<T>(string path, object body)
        {
            var r = await _http.PostAsJsonAsync(path, body);
            r.EnsureSuccessStatusCode();
            var asddd = await r.Content.ReadAsStringAsync();
            return await r.Content.ReadFromJsonAsync<T>() ??
                   throw new Exception("Deserialize error");
        }
    }
}