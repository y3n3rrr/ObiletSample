using System.Text.Json.Serialization;

namespace ObiletJourneyApp.Models.DTO
{
    public class GetSessionResponse
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("data")]
        public required GetSessionResponseDataDto Data { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("user-message")]
        public string? UserMessage { get; set; }

        [JsonPropertyName("api-request-id")]
        public string? ApiRequestId { get; set; }

        [JsonPropertyName("controller")]
        public string? Controller { get; set; }

        [JsonPropertyName("client-request-id")]
        public string? ClientRequestId { get; set; }

        [JsonPropertyName("web-correlation-id")]
        public string? WebCorrelationId { get; set; }

        [JsonPropertyName("correlation-id")]
        public string? CorrelationId { get; set; }

        [JsonPropertyName("parameters")]
        public object? Parameters { get; set; }
    }

    public class GetSessionResponseDataDto : DeviceSessionDto
    {

        [JsonPropertyName("affiliate")]
        public string? Affiliate { get; set; }

        [JsonPropertyName("device-type")]
        public int DeviceType { get; set; }

        [JsonPropertyName("device")]
        public string? Device { get; set; }

        [JsonPropertyName("ip-country")]
        public string? IpCountry { get; set; }

        [JsonPropertyName("clean-session-id")]
        public int CleanSessionId { get; set; }

        [JsonPropertyName("clean-device-id")]
        public int CleanDeviceId { get; set; }

        [JsonPropertyName("ip-address")]
        public string? IpAddress { get; set; }
    }
}