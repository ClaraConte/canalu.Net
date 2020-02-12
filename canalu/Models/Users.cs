using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace canalu.Models
{
    public class Users
    {
        [Display(Name = "Código")]
        [Key]
        public int IdUsers { get; set; }
        [Display(Name = "Nombre")]
        public string UsersFirstName { get; set; }
        [Display(Name = "Apellido")]
        public string UsersLastName { get; set; }
        [Display(Name = "DNI (DU)")]
        public long UsersDni { get; set; }
        [Display(Name = "Teléfono")]
        public string UsersPhone { get; set; }
        [Display(Name = "Email")]
        public string UsersEmail { get; set; }
        [Display(Name = "Fecha nacimento")]
        public DateTime UsersBirthDay { get; set; }
        [Display(Name = "Domicilio")]
        public ICollection<Address> address { get; set; }
        [Display(Name = "Empleado")]
        public virtual Employees Employees { get; set; }

    }
}
