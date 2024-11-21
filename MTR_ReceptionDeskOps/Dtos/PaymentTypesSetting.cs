using Domain.gettaxiusa.com.AbstractBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.gettaxiusa.com.Entities {
    public class PaymentTypesSetting 
    {
        public int? Id { get; set; }
        public int? DomainId { get; set; }
        public string? PaymentType { get; set; }
        public bool? ProductionMode { get; set; }
        public bool? TestingMode { get; set; }
        public bool? PaymentGateway { get; set; }
        public string? SecretKey { get; set; }
        public string? PublicKey { get; set; }
        public string? TestingSecretKey { get; set; }
        public string? TestingPublicKey { get; set; }
    }
}
