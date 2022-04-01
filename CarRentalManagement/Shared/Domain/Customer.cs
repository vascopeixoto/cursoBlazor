using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required(ErrorMessage = "Enter the First name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Invalid Size")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter the Last name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Invalid Size")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter the Tax Id")]
        public string TaxId { get; set; }

        public string Address { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Type")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Enter the Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public virtual List<Booking> Bookings { get; set; }

    }
}