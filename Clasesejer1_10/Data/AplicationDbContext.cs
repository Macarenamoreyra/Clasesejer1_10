using Microsoft.EntityFrameworkCore;

namespace Clasesejer1_10.Data
{
    public class AplicationDbContext : DbContext

    {
        public DbSet<Vehículo> vehiculos{ get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=PruebaEF;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
