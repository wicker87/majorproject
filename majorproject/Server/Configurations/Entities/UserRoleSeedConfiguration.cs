using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace majorproject.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3673afc7-4872-4f41-b547-68ba12781605", // Admin role ID
                    UserId = "efcd6d60-2001-4cd5-870a-0eeac7dfb1c9"  // Admin user ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = "48722b12-7612-4c81-9bbb-e5cf23432461", // Manager role ID
                    UserId = "3c45ecdd-8bab-4b76-9cc4-00580f013358"  // Manager user ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc", // Employee role ID
                    UserId = "151c4f5d-3c53-4474-9218-639d430f1f06"  // Employee user ID
                }
            );
        }
    }
}
