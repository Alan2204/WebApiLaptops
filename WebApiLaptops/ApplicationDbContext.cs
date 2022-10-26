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
<<<<<<< HEAD
=======

>>>>>>> 0ce185813bd1120e2945be2041e297f00633c0c7
    }
}
