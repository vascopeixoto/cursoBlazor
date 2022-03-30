using System;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Brand> _brands;
        private IGenericRepository<Color> _colors;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Model> _models;
        private IGenericRepository<Vehicle> _vehicles;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Brand> Brands => _brands ??= new GenericRepository<Brand>(_context);
        public IGenericRepository<Color> Colors => _colors ??= new GenericRepository<Color>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);
        public IGenericRepository<Model> Models => _models ??= new GenericRepository<Model>(_context);
        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                q.State == EntityState.Added);
            foreach (var item in entries)
            {
                ((BaseDomainModel)item.Entity).UpdatedBy = user;
                ((BaseDomainModel)item.Entity).DateUpdated = DateTime.Now;
                if (item.State == EntityState.Added)
                {
                    ((BaseDomainModel)item.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)item.Entity).CreatedBy = user;

                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
