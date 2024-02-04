using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatinumCityManagement.Shared.Domain;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
	public class CinemaBranchSeedConfiguration : IEntityTypeConfiguration<CinemaBranch>
	{
		public void Configure(EntityTypeBuilder<CinemaBranch> builder)
		{
			builder.HasData(
				new CinemaBranch
				{
					Id = 1,
					Name = "Platinum City Tampines",
					Address = "Tampines",
					HallQuantity = 9,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new CinemaBranch
				{
					Id = 2,
					Name = "Platinum City Bedok",
					Address = "Bedok",
					HallQuantity = 10,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new CinemaBranch
				{
					Id = 3,
					Name = "Platinum City Jewel",
					Address = "Jewel Changi Airport",
					HallQuantity = 8,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}
