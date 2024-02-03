using PlatinumCityManagement.Shared.Domain;

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
		IGenericRepository<Seat> Seats { get; }
	}
}