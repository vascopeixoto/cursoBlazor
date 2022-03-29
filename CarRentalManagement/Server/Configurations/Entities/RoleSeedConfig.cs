using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = "5b049e14-0ca3-4e35-ad1e-53518de8d7ff",
                   Name = "User",
                   NormalizedName = "USER",
               },
               new IdentityRole
               {
                   Id = "5a2687a4-00b6-45e0-b68c-3d7b29de1611",
                   Name = "Administrator",
                   NormalizedName = "ADMINISTRATOR"
               }
               );
        }
    }
}