

using MeasurementsApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MeasurementsApi.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=materialdb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Material> Material { get; set; }
    }
}