using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.De.Facturacion.Web.Models
{
    public class Document
    {
        [Key]
        public int ID_Doc { get; set; }

        [Required]
        [Display(Name = "Tipo De Documento")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Documento { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Seller> Sellers { get; set; }


    }
}
