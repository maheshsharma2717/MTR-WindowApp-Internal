using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities
{
    public class VechileTypes : BaseEntity
    {
        public int Id { get; set; }
        public string? VechileType { get; set; }

    }
}
