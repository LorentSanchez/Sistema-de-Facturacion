using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class Articles
    {// verifica la relacion 
        [Key]
        public int ArticlesId { get; set; }

        [Required]
        [Display(Name = "Articulos")]
        public string ArticlesName { get; set; }


        public int ArtcId { get; set; }

        public ArticleClassification ClassificationArts { get; set; }

        public int BrandId { get; set; }

        public Brand Brands { get; set; }
    }
}
