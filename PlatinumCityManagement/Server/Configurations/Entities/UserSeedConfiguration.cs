using PlatinumCityManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
				new ApplicationUser
				{
					Id = "c0ffdf85-d757-4286-8e84-b16117b416c8",
					Email = "lee@gmail.com",
					NormalizedEmail = "LEE@GMAIL.COM",
					FirstName = "Johnny",
					LastName = "Lee",
					UserName = "lee@gmail.com",
					NormalizedUserName = "LEE@GMAIL.COM",
					PasswordHash = hasher.HashPassword(null, "P@ssword1")
				},
				new ApplicationUser
				{
					Id = "1c8e4151-99c2-4a65-9cf1-53ade661a38e",
					Email = "tan@gmail.com",
					NormalizedEmail = "TAN@GMAIL.COM",
					FirstName = "Yan",
					LastName = "Teo",
					UserName = "tan@gmail.com",
					NormalizedUserName = "TAN@GMAIL.COM",
					PasswordHash = hasher.HashPassword(null, "P@ssword1")
				}
			);
        }
    }
}
