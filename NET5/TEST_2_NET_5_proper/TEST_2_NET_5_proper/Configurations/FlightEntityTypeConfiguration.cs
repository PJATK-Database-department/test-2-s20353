using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Test_2.Models;

namespace Test_2.Configurations
{
    public class FlightEntityTypeConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasData(
                new Flight { IdFlight = 1, FlightDate = DateTime.Now, IdPlane = 1, IdCityDict = 1 },
                new Flight { IdFlight = 2, FlightDate = DateTime.Now, Comments = "generic comment",  IdPlane = 2, IdCityDict = 2});
        }
    }
}
