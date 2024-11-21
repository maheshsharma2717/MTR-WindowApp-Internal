using Domain.gettaxiusa.com.AbstractBase;
using System.ComponentModel.DataAnnotations;

namespace Domain.gettaxiusa.com.Entities {
    public class States  {
        public int? id { get; set; }
        public string? name { get; set; }
        public int? countryid { get; set; }
    } 
    public class City  {
        public int? id { get; set; }
        public string? name { get; set; }
        public int? stateid { get; set; }
        public int? countryid { get; set; }
    }
}
