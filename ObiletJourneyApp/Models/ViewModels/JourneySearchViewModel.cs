using System;
using System.ComponentModel.DataAnnotations;

namespace ObiletJourneyApp.Models.ViewModels
{
    public class JourneySearchViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Origin ID must be greater than 0.")]
        public int OriginId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Destination ID must be greater than 0.")]
        public int DestinationId { get; set; }

        [Required(ErrorMessage = "Departure date is required.")]
        [DataType(DataType.Date)]
        public DateTime DepartDate { get; set; }
    }
}