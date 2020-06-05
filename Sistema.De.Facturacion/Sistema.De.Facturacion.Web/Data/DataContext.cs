using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.De.Facturacion.Web.Models;

namespace Sistema.De.Facturacion.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {

        }
        public DbSet<Sistema.De.Facturacion.Web.Models.Customer> Customer { get; set; }
        public DbSet<Sistema.De.Facturacion.Web.Models.Employee> Employee { get; set; }
        public DbSet<Sistema.De.Facturacion.Web.Models.Document> Document { get; set; }
    }
}
