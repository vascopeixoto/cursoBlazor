using System;
using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserSeedConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hash = new PasswordHasher<ApplicationUser>();
            builder.HasData(
               new ApplicationUser
               {
                   Id = "69781bdf-c47c-423d-b9c0-8e1934b99a69",
                   Email = "admin@localhost.com",
                   NormalizedEmail = "ADMIN@LOCALHOST.COM",
                   FirstName = "System",
                   LastName = "Admin",
                   UserName = "admin@localhost.com",
                   NormalizedUserName = "ADMIN@LOCALHOST.COM",
                   PasswordHash = hash.HashPassword(null, "admin")
               },
               new ApplicationUser
               {
                   Id = "48781bdf-c47c-423d-b9c0-8e1934b99a69",
                   Email = "user@localhost.com",
                   NormalizedEmail = "USER@LOCALHOST.COM",
                   FirstName = "System",
                   LastName = "User",
                   UserName = "user@localhost.com",
                   NormalizedUserName = "USER@LOCALHOST.COM",
                   PasswordHash = hash.HashPassword(null, "1234")
               }
               );
        }
    }
}
