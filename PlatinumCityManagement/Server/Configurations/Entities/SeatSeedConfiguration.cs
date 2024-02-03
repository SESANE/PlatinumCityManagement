using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatinumCityManagement.Shared.Domain;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class SeatSeedConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasData(
                new Seat
                {
                    Id = 1,
                    SeatNo = "A1",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

				new Seat
				{
					Id = 2,
					SeatNo = "A2",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},

				new Seat
				{
					Id = 3,
					SeatNo = "A3",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
				new Seat
				{
					Id = 4,
					SeatNo = "A4",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
				new Seat
				{
					Id = 5,
					SeatNo = "A5",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
				new Seat
				{
					Id = 6,
					SeatNo = "A6",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
				new Seat
				{
					Id = 7,
					SeatNo = "A7",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
				new Seat
				{
					Id = 8,
					SeatNo = "A8",
					SeatTaken = false,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
				new Seat
				{
					Id = 9,
					SeatNo = "A9",
					SeatTaken = true,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
				new Seat
				{
					Id = 10,
					SeatNo = "A10",
					SeatTaken = true,
					HallId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				}
			);
        }
    }
}
