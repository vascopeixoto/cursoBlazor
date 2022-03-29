using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                   UserId = "48781bdf-c47c-423d-b9c0-8e1934b99a69"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                   UserId = "69781bdf-c47c-423d-b9c0-8e1934b99a69"
               }
               );
        }
    }
}