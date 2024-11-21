using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities {
    public class SeatingPlan : BaseEntity {
        public int Id { get; set; }
        public string? SeatingPlanType { get; set; }

    }
}
