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
        public int BrandId { get; set; }

        [Required]
        [Display(Name = "Marcas")]
        public string BrandName { get; set; }



        public Articles Articles { get; set; }
    }
}
