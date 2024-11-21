using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.gettaxiusa.com.Entities
{
    public class EmployeeLogin 
    {
        public string? LoginId { get; set; }
        public string? Password { get; set; }
    }
    public class EmployeeLoginResponce
    {
        public int? domainId { get; set; }
        public string? FirstName { get; set; }
        public int? Status { get; set; }
        public string? domainName { get; set; }
        public string? nickName { get; set; }
        public string message { get; set; }
    }

}
