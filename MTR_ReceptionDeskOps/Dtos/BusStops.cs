using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities {
    public class BusStops {
        public int? StopId { get; set; }
        public string? StopName { get; set; }
        public string? DropStopName { get; set; }
        public string? TitleName { get; set; }
        public int? DestinationId { get; set; }
        public string? Distance { get; set; }
        public string? TravelingTime { get; set; }
        public string? Cost {  get; set; }
        public bool?Main {  get; set; }
    }
}

