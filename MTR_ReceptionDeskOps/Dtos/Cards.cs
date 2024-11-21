using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.gettaxiusa.com.Entities {
    public class Cards : BaseEntity {
        public int CardId { get; set; }
        public long? CardNumber { get; set; }
        public string? CardHolderName { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? CVV { get; set; }
        public int? PassengerId { get; set; }
        public PassengerDetail? PassengerDetail { get; set; }

    }
}
