using System.ComponentModel.DataAnnotations;

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
