using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities
{
    public class BusTimingDto : BaseEntity
    {
        public int? BusTimingId { get; set; }
        public int? DomainId { get; set; }
        public string? Model { get; set; }
        public string? PlateNumber { get; set; }
        public string? Color { get; set; }
        public string? NumberOfSeatsAvailable { get; set; }
        public string? SeatingPlan { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public int?DestinationId { get; set; }
        //public int? BusId { get; set; }

        //[ForeignKey("BusId")]
        //public Vehicles? Vechile { get; set; }

        //public int? RouteId { get; set; }

        //[ForeignKey("RouteId")]
        //public Destination? Destination { get; set; }
        public Destination? Destination { get; set; }

    }
}
