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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
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
					ScreeningId = 1,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System",
				},
                new Seat
                {
                    Id = 21,
                    SeatNo = "A1",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

                new Seat
                {
                    Id = 22,
                    SeatNo = "A2",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

                new Seat
                {
                    Id = 23,
                    SeatNo = "A3",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 24,
                    SeatNo = "A4",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 25,
                    SeatNo = "A5",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 26,
                    SeatNo = "A6",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 27,
                    SeatNo = "A7",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 28,
                    SeatNo = "A8",
                    SeatTaken = false,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 29,
                    SeatNo = "A9",
                    SeatTaken = true,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 30,
                    SeatNo = "A10",
                    SeatTaken = true,
                    ScreeningId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 31,
                    SeatNo = "A1",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

                new Seat
                {
                    Id = 32,
                    SeatNo = "A2",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },

                new Seat
                {
                    Id = 33,
                    SeatNo = "A3",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 34,
                    SeatNo = "A4",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 35,
                    SeatNo = "A5",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 36,
                    SeatNo = "A6",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 37,
                    SeatNo = "A7",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 38,
                    SeatNo = "A8",
                    SeatTaken = false,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 39,
                    SeatNo = "A9",
                    SeatTaken = true,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new Seat
                {
                    Id = 40,
                    SeatNo = "A10",
                    SeatTaken = true,
                    ScreeningId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
        }
    }
}
