using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Display(Name = "Usuario")]
        [ForeignKey("IdUsers")]
        public int IdUsers { get; set; }
        public int IdAddressType { get; set; }
        public string AddressObservations { get; set; }
        public virtual Commerces Commerces { get; set; }
        public int IdLocations { get; set; }
        public Locations locations { get; set; }
    }
}
