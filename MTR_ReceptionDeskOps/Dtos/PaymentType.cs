using Domain.gettaxiusa.com.AbstractBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.gettaxiusa.com.Entities {
    public class PaymentType : BaseEntity{
        public int Id { get; set; }
        public string? PaymentWay { get; set; }
        public string? Amount { get; set; }
        public string? TransactionId { get; set; }
        public string? Status { get; set; }
        public string? PostValue { get; set; }
        public int? DomainId { get; set; }

    }
}
