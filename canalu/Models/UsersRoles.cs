
using System;
using System.ComponentModel.DataAnnotations;

namespace canalu.Models
{
    public class UsersRoles
    {
        [Display(Name = "Código")]
        [Key]
        public int IdUsersRoles { get; set; }
        public string UsersRolesName { get; set; }

    }
}
