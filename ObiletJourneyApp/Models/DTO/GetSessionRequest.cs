using System.Text.Json.Serialization;

namespace ObiletJourneyApp.Models.DTO
{
    public class GetSessionRequest
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("connection")]
        public required ConnectionInfoDto Connection { get; set; }

        [JsonPropertyName("browser")]
        public required BrowserInfoDto Browser { get; set; }
    }

    public class ConnectionInfoDto
    {
        [JsonPropertyName("ip-address")]
        public required string IpAddress { get; set; }

        [JsonPropertyName("port")]
        public required string Port { get; set; }
    }

    public class BrowserInfoDto
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("version")]
        public required string Version { get; set; }
    }
}