using System.Text.Json.Serialization;

namespace ObiletJourneyApp.Models.DTO
{
    public class DeviceSessionDto
    {
        [JsonPropertyName("session-id")]
        public required string SessionId { get; set; }

        [JsonPropertyName("device-id")]
        public required string DeviceId { get; set; }
    }

}
