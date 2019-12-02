using System;
using System.ComponentModel.DataAnnotations;

namespace canalu.Models
{
    public class Address
    {
        [Display(Name = "Código")]
        [Key]
        public int IdAddress { get; set; }
        public string AddressStreet { get; set; }
        public string AddressNumber { get; set; }
        public string AddressDptoFloor { get; set; }
        public string AddressDptoNumber { get; set; }
        public Decimal AddressLatitude { get; set; }
        public Decimal AddressLongitude { get; set; }
        public int IdAddressType { get; set; }
        public string AddressObservations { get; set; }
        public int IdLocations { get; set; }
        public Locations locations { get; set; }
    }
}
