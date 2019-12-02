using System;
using System.ComponentModel.DataAnnotations;

namespace canalu.Models
{
    public class Locations
    {
        [Display(Name = "Código")]
        [Key]
        public int IdLocations { get; set; }
        public int IdProvinces { get; set; }
        public Provinces provinces { get; set; }
        public string LocationsName { get; set; }
    }
}
