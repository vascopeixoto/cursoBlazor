using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
               new Model
               {
                   Id = 1,
                   Name = "Prius",
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",

               },
               new Model
               {
                   Id = 2,
                   Name = "Yaris",
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",

               },
               new Model
               {
                   Id = 3,
                   Name = "M4",
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",

               },
               new Model
               {
                   Id = 4,
                   Name = "i8",
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",

               }
               );
        }
    }
}
