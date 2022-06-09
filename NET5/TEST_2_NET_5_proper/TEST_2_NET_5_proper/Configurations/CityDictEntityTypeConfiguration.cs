using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test_2.Models;

namespace Test_2.Configurations
{
    public class CityDictEntityTypeConfiguration : IEntityTypeConfiguration<CityDict>
    {
        public void Configure(EntityTypeBuilder<CityDict> builder)
        {
            builder.HasData(
                new CityDict { IdCityDict = 1, City = "Warszawa" },
                new CityDict { IdCityDict = 2, City = "Tokyo" });
        }
    }
}
