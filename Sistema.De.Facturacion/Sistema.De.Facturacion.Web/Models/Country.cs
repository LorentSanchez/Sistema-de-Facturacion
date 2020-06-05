using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Nombre De Pais")]
        public string CountryName { get; set; }

        [Display(Name ="Estado")]
        public ICollection<State> States { get; set; }
    }
}
