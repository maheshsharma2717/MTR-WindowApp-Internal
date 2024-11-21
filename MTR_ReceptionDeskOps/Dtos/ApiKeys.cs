using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.gettaxiusa.com.Entities {
    public class ApiKeys : BaseEntity {
        public int ApiId { get; set; }
        public string? ApiKey { get; set; }
        public int? DomainId { get; set; }
    }
}
