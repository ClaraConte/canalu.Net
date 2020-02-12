using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace canalu.Models
{
    public class Commerces
    {
        [Display(Name = "Código")]
        [Key]
        public int IdCommerces { get; set; }
        public string CommercesName { get; set; }
        public string CommercesRS { get; set; }

    }
}
