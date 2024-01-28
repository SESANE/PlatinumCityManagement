using PlatinumCityManagement.Server.IRepository;
using PlatinumCityManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatinumCityManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<CinemaBranch> CinemaBranches { get; }
        IGenericRepository<Hall> Halls { get; }
        IGenericRepository<Screening> Screenings { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}