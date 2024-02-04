using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatinumCityManagement.Shared.Domain;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class ScreeningSeedConfiguration : IEntityTypeConfiguration<Screening>
    {
        public void Configure(EntityTypeBuilder<Screening> builder)
        {
            builder.HasData(
                new Screening
                {
                    Id = 1,
                    Price = 10,
                    Showtime = new DateTime(2024, 2, 3, 20, 0, 0), // Example: February 3, 2024 at 20:00
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    HallId = 1,
                    MovieId = 1,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Screening
                {
                    Id = 2,
                    Price = 12,
                    Showtime = new DateTime(2024, 2, 4, 20, 0, 0), // Example: February 4, 2024 at 20:00
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    HallId = 2,
                    MovieId = 1,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Screening
                {
                    Id = 3,
                    Price = 15,
                    Showtime = new DateTime(2024, 2, 3, 18, 0, 0), // Example: February 3, 2024 at 18:00
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    HallId = 3,
                    MovieId = 1,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }

       
    }
}
