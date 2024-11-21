using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities {
    public class Destination :BaseEntity{
        public int DestinationId { get; set; }
        public string? DestinationName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? FullAddress { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public int? ZipCode { get; set; }
        public string? City { get; set; }
        public int? Distance { get; set; }
        public string? TravelingTime { get; set; }
        public string? CostPerMile { get; set; }
        public int? DomainId { get; set; }
        public ICollection<BusStops>? BusStops { get; set; }
        public string DisplayName => $" {FullAddress} - {DestinationName}";

    }
}

