using Microsoft.EntityFrameworkCore;
using ShahanLawOffice.Domain.ClientAgg;
namespace ShahanLawOffice.Persistence.Context
{
    internal class LawOfficeDB : DbContext
    {
        protected LawOfficeDB()
        {
        }

       // public DbSet<Client> Clients { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ConfigModels();
        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Clean41 ; integrated security = true");
        //    base.OnConfiguring(optionsBuilder);
        //}


    }
}
