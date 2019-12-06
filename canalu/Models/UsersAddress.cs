using System;
using System.ComponentModel.DataAnnotations;

namespace canalu.Models
{
    public class UsersAddress
    {
        [Display(Name = "Código")]
        [Key]
        public int IdUsers { get; set; }
        [Display(Name = "Nombre")]
        public string UsersFirstName { get; set; }
        [Display(Name = "Apellido")]
        public string UsersLastName { get; set; }
        [Display(Name = "DNI (DU)")]


        public Address Addres { get; set; }

        public long UsersDni { get; set; }
        [Display(Name = "Teléfono")]
        public string UsersPhone { get; set; }
        [Display(Name = "Email")]
        public string UsersEmail { get; set; }
        [Display(Name = "Fecha nacimento")]
        public DateTime UsersBirthDay { get; set; }
    }
}
