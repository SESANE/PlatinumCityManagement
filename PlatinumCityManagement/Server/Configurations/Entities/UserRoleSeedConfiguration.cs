using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },
				new IdentityUserRole<string>
				{
					RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
					UserId = "c0ffdf85-d757-4286-8e84-b16117b416c8"
				},
				new IdentityUserRole<string>
				{
					RoleId = "b6ae90e2-c81c-444d-8aae-6fc935b403f2",
					UserId = "1c8e4151-99c2-4a65-9cf1-53ade661a38e"
				}
			);
        }
    }
}
