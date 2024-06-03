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
                new IdentityUserRole<string> // 1
                {
                    RoleId = "ce6c922d-a075-41ba-928b-ab718da843f4", // Admin role ID
                    UserId = "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc"  // Admin user ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = "b61949be-76be-449f-bc66-535bddbf7b90", // Manager role ID
                    UserId = "23cdf685-e508-4fc6-84cc-c860af2dd301"  // Manager user ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc", // Employee role ID
                    UserId = "5859b058-1d6e-4b79-8040-9bbd204c0dc5"  // Employee user ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "f53bf9d9-95d1-42af-804e-e5edacdc9c74"
                },
                new IdentityUserRole<string> // 5
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "5258daf7-0bf7-4460-a854-4b3f427312c7"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "b61949be-76be-449f-bc66-535bddbf7b90",
                    UserId = "e7b4016a-fa59-4669-969f-36601182f51c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "cda313e3-33c1-4e6e-982b-3c5eb9ff9565"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "b61949be-76be-449f-bc66-535bddbf7b90",
                    UserId = "8d06620d-3d31-4c1c-9449-7eaac032f6bd"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "77ea0c8c-fa62-4e13-980a-63ed5336f0b2"
                },
                new IdentityUserRole<string> // 10
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "b57e892b-0bdb-4469-afd9-e6522fea2f25"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "fe8964fa-aac1-4db1-97bb-017e0905242f"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "33a4bc04-9b10-49a5-8cb6-8dea48b122c4"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "1519fcce-c355-4cad-8b22-01b76b762ffc"
                },
                new IdentityUserRole<string> // 15
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "63929151-0e12-4c5c-a03c-01c34642856a"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "b61949be-76be-449f-bc66-535bddbf7b90",
                    UserId = "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "e5e8acfe-c59a-4b4d-bba4-d40057aecef4"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a7b95d75-9c36-45cf-993f-504090b554cc",
                    UserId = "6f84b324-5cc8-48b6-a348-57c74b3d5294"
                },
                new IdentityUserRole<string> // 20
                {
                    RoleId = "b61949be-76be-449f-bc66-535bddbf7b90",
                    UserId = "911dd5ac-5093-444e-bd8d-b6fed36dcada"
                }
            );
        }
    }
}
