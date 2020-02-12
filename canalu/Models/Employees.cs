using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace canalu.Models
{
    public class Employees
    {
        [Display(Name = "Código")]
        [Key]
        public int IdEmployees { get; set; }
        public string EmployeesUserName { get; set; }
        [RequiredAttribute]
        public string EmployeesKey { get; set; }
        public Boolean EmployeesStatus { get; set; }

        [Display(Name = "Usuario")]
        [ForeignKey("IdUsers")]
        public int IdUsers { get; set; }

        public int IdUsersRoles { get; set; }
        [Display(Name = "Rol")]
        [ForeignKey("IdUsersRoles")]
        public UsersRoles usersRoles { get; set; }

    }
}
