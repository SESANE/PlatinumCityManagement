using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatinumCityManagement.Shared.Domain;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class HallSeedConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasData(
                new Hall
                {
                    Id = 1,
                    Name = "1",
                    ScreeningQuality = "IMAX",
                    Capacity = 100,
                    CinemaBranchId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

				new Hall
				{
					Id = 2,
					Name = "1",
					ScreeningQuality = "DOLBY ATMOS",
					Capacity = 90,
					CinemaBranchId = 2,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},

				new Hall
				{
					Id = 3,
					Name = "1",
					ScreeningQuality = "HD",
					Capacity = 80,
					CinemaBranchId = 3,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
        }
    }
}
