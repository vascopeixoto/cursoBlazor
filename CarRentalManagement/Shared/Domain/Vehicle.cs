using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }

        [Required]
        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        [Required]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Color Color { get; set; }

        [Required]
        public int ColorId { get; set; }

        public string Vin { get; set; }

        [Required]
        public string LicensePlateNumber { get; set; }

        [Required]
        public double RentalRate { get; set; }

        public virtual List<Booking> Bookings { get; set; }

    }
}