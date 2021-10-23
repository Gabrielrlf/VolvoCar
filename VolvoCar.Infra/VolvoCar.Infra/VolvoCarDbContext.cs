using Microsoft.EntityFrameworkCore;
using System;
using VolvoCar.Domain.Model;

namespace VolvoCar.Infra
{
    public class VolvoCarDbContext : DbContext
    {
        public DbSet<Truck> Truck { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite(@"Data Source=C:\dados\Volvocar.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Truck>()
                .HasData(
                    new Truck() { Id = 1, ModelName = "FH", YearModel = 2022, YearFabrication = DateTime.Now.Year, CreationDate = DateTime.Now, UpdateDate = DateTime.Now }
                );
        }

    }
}
