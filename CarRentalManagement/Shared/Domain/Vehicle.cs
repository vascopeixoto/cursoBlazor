using System;
using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public int ColorId { get; set; }
        public string Vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public double RentalRate { get; set; }
        public virtual List<Booking> Bookings { get; set; }

    }
}