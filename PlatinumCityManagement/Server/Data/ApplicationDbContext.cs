using CarRentalManagement1.Server.Configurations.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PlatinumCityManagement.Server.Configurations.Entities;
using PlatinumCityManagement.Server.Models;
using PlatinumCityManagement.Shared.Domain;

namespace PlatinumCityManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<CinemaBranch> CinemaBranches { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Screening> Screenings { get; set; }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new MovieSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());

        }
    }
}
