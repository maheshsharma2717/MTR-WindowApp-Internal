using Domain.gettaxiusa.com.AbstractBase;
using Domain.gettaxiusa.com.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.gettaxiusa.com.Entities
{
    public class Vehicles : BaseEntity
    {
       
        public int VehicleId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? VehicleName { get; set; }
        public string? PlateNumber { get; set; }
        public string? SeatingPlan { get; set; }
        public int? DestinationId { get; set; }
        public string? VehicleColor { get; set; }
        public string? NumberOfSeatsAvailable { get; set; }
        public decimal? CostPerSeats { get; set; }
        public bool? IsActive { get; set; }
        public string? VehiclePicture { get; set; }
        public string? DomainId { get; set; }
        public bool? IsAc { get; set; }
        public bool? IsKidsFree { get; set; }
        public List<int> Hotels { get; set; } = new List<int>();

        //public int? DriverInfoId { get; set; }
        //public string? State { get; set; }
        //public int? Status { get; set; }
        //public string? Model { get; set; }
        //public string? VehicleType { get; set; }
        //public string? RegName { get; set; }
        //public string? RegPhone { get; set; }
        //public string? RegCell { get; set; }
        //public string? RegAddress { get; set; }

        //public string? Note { get; set; }
        //public int? IsDeleted { get; set; }
        //public string? RegCity { get; set; }
        //public string? RegState { get; set; }
        //public string? RegZip { get; set; }
        //public int? VehicleProcessingStatus { get; set; }
        //public bool? IsAccessride { get; set; }
        //public bool? IsWheelchair { get; set; }
        //public bool? IsLuxury { get; set; }
        public VechileTypes? VehileTypes { get; set; }
        public Destination? Destination { get; set; }
    }
}


