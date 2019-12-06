using System.ComponentModel.DataAnnotations;

namespace canalu.Models
{
    public class Provinces
    {
        [Display(Name = "Código")]
        [Key]
        public int IdProvinces { get; set; }
        public string ProvincesName { get; set; }
    }
}
