using majorproject.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "efcd6d60-2001-4cd5-870a-0eeac7dfb1c9",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    Position = "Administrator",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "3c45ecdd-8bab-4b76-9cc4-00580f013358",
                    Email = "manager@localhost.com",
                    NormalizedEmail = "MANAGER@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Manager",
                    Position = "Manager",
                    UserName = "manager@localhost.com",
                    NormalizedUserName = "MANAGER@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword2")
                },
                new ApplicationUser
                {
                    Id = "151c4f5d-3c53-4474-9218-639d430f1f06",
                    Email = "employee@localhost.com",
                    NormalizedEmail = "EMPLOYEE@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Employee",
                    Position = "Employee",
                    UserName = "employee@localhost.com",
                    NormalizedUserName = "EMPLOYEE@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword3")
                }
            );
        }
    }
}
