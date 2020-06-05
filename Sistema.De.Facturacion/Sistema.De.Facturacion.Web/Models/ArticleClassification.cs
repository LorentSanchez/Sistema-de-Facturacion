using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class ArticleClassification
    { //verifica la relaccion 
        [Key]
        public int ArtC_Id { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Tipo de Artículo")]
        public string Name_ArtC { get; set; }


        public ICollection<Article> Articles { get; set; }
    }
}
