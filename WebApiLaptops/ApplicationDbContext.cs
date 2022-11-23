using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using WebApiLaptops.Entidades;

namespace WebApiLaptops
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {        

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<LapCaracteristica>()
                .HasKey(lap => new { lap.LapId, lap.ModeloId });
        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Caracteristicas> Caracteristicas { get; set; }
        public DbSet<LapCaracteristica> LapCaracteristicas { get; set; }
    }
}
