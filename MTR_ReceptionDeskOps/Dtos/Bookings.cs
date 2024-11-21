using Domain.gettaxiusa.com.AbstractBase;
namespace Domain.gettaxiusa.com.Entities
{
    public class BookingDetails : BaseEntity
    {
        public long? BookingId { get; set; }
        public int? NumberOfGuest { get; set; }
        public int? StaffId { get; set; }
        public string? RoomNumber { get; set; }
        public DateTime? DepartureOn { get; set; }
        public bool? BookingStatus { get; set; }
        public int? TotalNumberOfPerson { get; set; }
        public int? HotelId { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? TravelTime { get; set; }
        public int? KidsUnder2Years { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? VehicleId { get; set; }
        public string? SeatNumber { get; set; }
        public int? NumberOfSeatsBooked { get; set; }
        public int? DestinationId { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? PassangerId { get; set; }
        public int? DomainId { get; set; }
        public int? BusTimingId { get; set; }
        public string? PickUpLocation { get; set; }
        public string? DropOffLocation { get; set; }
        public Destination? Destination { get; set; }
        public Hotels? Hotel { get; set; }
        public PassengerDetail? PassengerDetail { get; set; }
        public Vehicles? Vehicle { get; set; }

        public PaymentType? PaymentType { get; set; }
        public BusTimingDto? BusTiming { get; set; }
        public List<BusSeatsBookedDetails> BusSeatsBookedDetailsList { get; set; }
    }
    public class BusSeatsBookedDetails
    {
        public int SeatNumber { get; set; }
        public string? SeatAssiendColor { get; set; }
        public bool IsBooked { get; set; }
        public bool IsSelected { get; set; }
    }
}
