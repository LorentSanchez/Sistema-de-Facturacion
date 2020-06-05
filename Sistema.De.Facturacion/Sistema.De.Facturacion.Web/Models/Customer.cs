﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class Customer
    {

        [Key]
        public int Customer_Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Nombre del cliente ")]
        public string NombreC { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Apellido del Cliente")]
        public string ApellidoC { get; set; }

        //-----Relacion Document-----
        [Display(Name = "Documento")]
        [ForeignKey("Document")]
        public int ID_Doc { get; set; }
        public Document Documents { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Display(Name = "Numero De Referencia")]
        public string Document { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Telefono")]
        public string TelefonC { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Correo { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Direccion")]
        public string DireccionC { get; set; }



        public string NombreCompleto => $"{NombreC} {ApellidoC}";


    }
}
