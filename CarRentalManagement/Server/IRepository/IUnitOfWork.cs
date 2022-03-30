using System;
using System.Threading.Tasks;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);

        IGenericRepository<Brand> Brands { get;}
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
    }
}
