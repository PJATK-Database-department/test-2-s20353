using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test_2.Models;

namespace Test_2.Configurations
{
    public class Flight_PassengerEntityTypeConfiguration : IEntityTypeConfiguration<Flight_Passenger>
    {
        public void Configure(EntityTypeBuilder<Flight_Passenger> builder)
        {
            builder.HasKey(e => e.IdPassenger);
            builder.HasKey(e => e.IdFlight);

            builder.HasData(
                new Flight_Passenger { IdPassenger = 1, IdFlight = 1 },
                new Flight_Passenger { IdPassenger = 2, IdFlight = 2 });
        }
    }
}
