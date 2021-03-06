﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class ClassifiCustomer
    {
      
        [Key]
        public int Classif_Customer_Id { get; set; }

        [Required]
        [Display(Name = "Clasificacion De Clientes ")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Classif_Customer { get; set; }

        public ICollection<Company> Companies { get; set; }



    }
}
