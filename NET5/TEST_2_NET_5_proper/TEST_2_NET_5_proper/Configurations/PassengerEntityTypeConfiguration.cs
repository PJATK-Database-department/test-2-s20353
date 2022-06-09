using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test_2.Models;

namespace Test_2.Configurations
{
    public class PassengerEntityTypeConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasData(
                new Passenger { IdPassenger = 1, FirstName = "John", LastName = "Doe", PassportNum = "ABC123"},
                new Passenger { IdPassenger = 2, FirstName = "Jane", LastName = "Smith", PassportNum = "DEF456" });
        }
    }
}
