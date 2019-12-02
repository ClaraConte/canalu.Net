using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace canalu.Models
{
    public class LoginView
    {
        [Key]
        public int id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
