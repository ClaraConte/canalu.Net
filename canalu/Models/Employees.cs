using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace canalu.Models
{
    public class Employees
    {
        [Display(Name = "Código")]
        [Key]
        public int IdEmployees { get; set; }
        public string EmployeesUserName { get; set; }
        public string EmployeesKey { get; set; }
        public Boolean EmployeesStatus { get; set; }
        public int IdUsers { get; set; }

        [Display(Name = "Usuario")]
        [ForeignKey("IdUsers")]
        public  Users users{ get; set; }

        public int IdUsersRoles { get; set; }
        [Display(Name = "Rol")]
        [ForeignKey("IdUsersRoles")]
        public UsersRoles usersRoles { get; set; }

    }
}
