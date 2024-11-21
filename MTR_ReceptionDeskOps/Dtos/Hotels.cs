using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities
{
    public class Hotels : BaseEntity
    {
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? HotelNumber { get; set; }
        public string? ContactNo { get; set; }
        public string? CountryCode { get; set; }
        public string? HotelPicture { get; set; }
        public string? PlateNumber { get; set; }
        public bool? IsActive { get; set; }
        public string? DomainId { get; set;}
        public bool? HotelStatus { get; set; }
    }

    public class HotelDto
    {
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? HotelNumber { get; set; }
        public string? ContactNo { get; set; }
        public string? CountryCode { get; set; }
        public string? HotelPicture { get; set; }
        public string? PlateNumber { get; set; }
        public bool? IsActive { get; set; }
        public string? DomainId { get; set; }
        public bool? HotelStatus { get; set; }
        public bool isChecked { get; set; }
    }

}
