using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities
{
    public class BookingTypes : BaseEntity
    {
        public int Id { get; set; }
        public string? BookingType { get; set; }
    }
}
