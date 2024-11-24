using airport.Entities;
using Microsoft.EntityFrameworkCore;

namespace airport
{
    public class DataContext: DbContext
    {
        public DbSet<Airplane> airplanes { get; set; }


        public DbSet<Company> companies { get; set; }

        public DbSet<Flight> flights { get; set; }

        public DbSet<Location> locations { get; set; }

        public DbSet<Status> statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Airport");
        }
    }
}
