using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities {
    public class PassengerDetail : BaseEntity {
        public int PassengerId { get; set; }
        public string? PassengerName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? NotifyPhone { get; set; }
        public bool? NotifyEmail { get; set; }
        public bool? IsConfirmed { get; set; }
    }
}

