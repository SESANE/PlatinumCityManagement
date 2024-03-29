﻿using CarRentalManagement1.Server.Configurations.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PlatinumCityManagement.Server.Configurations.Entities;
using PlatinumCityManagement.Server.Models;
using PlatinumCityManagement.Shared.Domain;
using System.Reflection.Emit;

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
		public DbSet<Seat> Seats { get; set; }
		public DbSet<Screening> Screenings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());
			builder.ApplyConfiguration(new CinemaBranchSeedConfiguration());
			builder.ApplyConfiguration(new HallSeedConfiguration());
			builder.ApplyConfiguration(new ScreeningSeedConfiguration());
			builder.ApplyConfiguration(new SeatSeedConfiguration());
            builder.ApplyConfiguration(new CustomerSeedConfiguration());
            builder.ApplyConfiguration(new MovieSeedConfiguration());

        }
    }
}
