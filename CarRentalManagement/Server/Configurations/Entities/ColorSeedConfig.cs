﻿using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ColorSeedConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
               new Color
               {
                   Id = 1,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "Black",
                   UpdatedBy = "System"
               },
               new Color
               {
                   Id = 2,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "Blue",
                   UpdatedBy = "System"
               },
               new Color
               {
                   Id = 3,
                   CreatedBy = "System",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   Name = "Red",
                   UpdatedBy = "System"
               }
               );
        }
    }
}
