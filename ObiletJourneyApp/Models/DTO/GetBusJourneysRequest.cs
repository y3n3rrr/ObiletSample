using System.Text.Json.Serialization;

namespace ObiletJourneyApp.Models.DTO
{
    public class GetBusJourneysRequest
    {
        [JsonPropertyName("device-session")]
        public DeviceSessionDto DeviceSession { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("data")]
        public JourneyData Data { get; set; }
    }

    public class JourneyData
    {
        [JsonPropertyName("origin-id")]
        public int OriginId { get; set; }

        [JsonPropertyName("destination-id")]
        public int DestinationId { get; set; }

        [JsonPropertyName("departure-date")]
        public string DepartureDate { get; set; }
    }
}