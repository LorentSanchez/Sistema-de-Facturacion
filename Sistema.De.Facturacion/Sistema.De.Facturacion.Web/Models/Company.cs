using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class Company
    {/// aqui revisa  la entidad emperesa, con su relacion de municipios  lo deje en comentarios 
        [Key]
        public int Company_Id { get; set; }

        [Required]
        [Display(Name = "Nombre De Empresa")]
        public string Company_Name { get; set; }

        [Required]
        [Display(Name = "Tipo De Empresa")]
        public string Type_Company { get; set; }
        [Required]
        [Display(Name = "Tipo Documento ")]
        public string Document_Company { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Numero De Referencia")]
        public string Document { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        //[Required]
        //[Display(Name = "Municipio")]
        //public string Municipio { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string correo { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        public string phone { get; set; }

    }
}
