using PlatinumCityManagement.Server.IRepository;
using PlatinumCityManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatinumCityManagement.Server.Data;
using PlatinumCityManagement.Server.IRepository;
using PlatinumCityManagement.Server.Repository;
using System.Security.Claims;

namespace PlatinumCityManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);

        IGenericRepository<Movie> Movies { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<CinemaBranch> CinemaBranches { get; }
        IGenericRepository<Hall> Halls { get; }
        IGenericRepository<Screening> Screenings { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}