using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WebApiLaptops.Entidades;

namespace WebApiLaptops
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {        

        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Caracteristicas> Caracteristicas { get; set; }
    }
}
