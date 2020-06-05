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
        public int ArtcId { get; set; }

        [Required]
        [Display(Name = "Clasificacion Articulos")]
        public string NameArtc { get; set; }


        public Articles Articles { get; set; }
    }
}
