using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class FormPago
    {/// Relacionado con moneda 
        
        [Key]
        public int Id_Pago { get; set; }

        ///Efectivo 
        [Required]
        [Display(Name = "Forma De Pago")]
        public string pago_Name { get; set; }

    }
}
