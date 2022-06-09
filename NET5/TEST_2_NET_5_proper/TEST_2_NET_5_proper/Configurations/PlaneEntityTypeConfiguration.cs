using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test_2.Models;

namespace Test_2.Configurations
{
    public class PlaneEntityTypeConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasData(
                new Plane { IdPlane = 1, Name = "FirstPlane", MaxSeats = 50 },
                new Plane { IdPlane = 2, Name = "SecondPlane", MaxSeats = 100 });
        }
    }
}
