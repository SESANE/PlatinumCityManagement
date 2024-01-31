using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatinumCityManagement.Shared.Domain;
using System.Drawing;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class BookingSeedConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    Id = 1, 
                    BookingType = "Regular",
                    SeatQty = 2,
                    SeatNo = "F5, F6",
                    BookingDateTime = new DateTime(2024, 1, 19, 18, 08, 33),
                }
                );
        }
    }
}
