using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlatinumCityManagement.Shared.Domain;
using System.Drawing;

namespace PlatinumCityManagement.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                  new Customer
                  {
                      Id = 1,
                      Name = "Johnny Lee",
                      DOB = new DateTime(2005, 7, 15),
                      Address = "707 Tampines Street 71 #09-20, 520707",
                      EmailAddress = "lee@gmail.com",
                      ContactNumber = "89220951",
                      MembershipType = "Premium",
                      Points = 133

                  }



);                  
        }
    }
}
