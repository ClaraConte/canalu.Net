using System;
using System.ComponentModel.DataAnnotations;

namespace canalu.Models
{
    public class RolesActions
    {
        [Display(Name = "Código")]
        [Key]
        public int IdRolesActions { get; set; }
        public string RolesActionsName { get; set; }
        public int IdRolesUsers { get; set; }
        public UsersRoles usersRoles { get; set; }
    }
}
