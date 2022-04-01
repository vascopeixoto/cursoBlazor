using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Brand : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }

    }
}
