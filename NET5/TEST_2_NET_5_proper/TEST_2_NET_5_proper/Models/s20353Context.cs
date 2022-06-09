using Microsoft.EntityFrameworkCore;
using Test_2.Configurations;

namespace Test_2.Models
{
    public class s20353Context : DbContext
    {
        protected s20353Context()
        {
        }

        public s20353Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Plane> Planess { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight_Passenger> Flight_Passengers { get; set; }
        public DbSet<CityDict> CityDicts { get; set; }
        public DbSet<Flight> Flights { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PassengerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PlaneEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FlightEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Flight_PassengerEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CityDictEntityTypeConfiguration());
        }
            
    }
}
