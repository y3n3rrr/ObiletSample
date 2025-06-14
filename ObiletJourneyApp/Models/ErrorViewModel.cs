using ObiletJourneyApp.Models.DTO;

namespace ObiletJourneyApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class SearchViewModel
    {
        public List<LocationDto> Origins { get; set; } = new List<LocationDto>(); 
        public List<LocationDto> Destinations { get; set; } = new List<LocationDto>(); 
        public int? OriginId { get; set; }
        public int? DestinationId { get; set; }
        public DateTime DepartDate { get; set; }
    }

  

}