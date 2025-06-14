using System;
using System.Text.Json.Serialization;

namespace ObiletJourneyApp.Models.DTO
{
    public class GetBusLocationsRequest
    {
        [JsonPropertyName("data")]
        public object? Data { get; set; } = null;

        [JsonPropertyName("device-session")]
        public required DeviceSessionDto DeviceSession { get; set; }

        [JsonPropertyName("date")]
        public required DateTime Date { get; set; }

        [JsonPropertyName("language")]
        public required string Language { get; set; }
    }

    
}