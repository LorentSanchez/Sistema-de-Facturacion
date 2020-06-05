using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class Brand
    { // verifica la relacion
        [Key]
        public int Brand_Id { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Marcas")]
        public string Brand_Name { get; set; }



        public ICollection<Article> Articless { get; set; }
    }
}
