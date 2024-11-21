using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities {
    public class Destination2 :BaseEntity{
        public int? DestinationId { get; set; }
        public int? DomainId { get; set; }
        public int? Distance { get; set; }
        public string? DestinationName { get; set; }
        public string? FullAddress { get; set; }
        public string? State { get; set; }
        public int? ZipCode { get; set; }
        public string? City { get; set; }
        public ICollection<BusStops>? BusStops { get; set; }
    }
}

