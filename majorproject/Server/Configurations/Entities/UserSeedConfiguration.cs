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
                new ApplicationUser // 1
                {
                    Id = "0923ec27-2dc5-46d5-a8a1-e48c70e69ecc",
                    Email = "janedoe@gmail.com",
                    NormalizedEmail = "JANEDOE@GMAIL.COM",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Designation = "IT Manager",
                    EmployeeID = 1003,
                    UserName = "janedoe@gmail.com",
                    NormalizedUserName = "JANEDOE@GMAIL.COM",
                    PhoneNumber = "64841415",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "23cdf685-e508-4fc6-84cc-c860af2dd301",
                    Email = "johnsmith@gmail.com",
                    NormalizedEmail = "JOHNSMITH@GMAIL.COM",
                    FirstName = "John",
                    LastName = "Smith",
                    Designation = "Safety Manager",
                    EmployeeID = 2010,
                    UserName = "johnsmith@gmail.com",
                    NormalizedUserName = "JOHNSMITH@GMAIL.COM",
                    PhoneNumber = "67349033",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "5859b058-1d6e-4b79-8040-9bbd204c0dc5",
                    Email = "stanleyhall@gmail.com",
                    NormalizedEmail = "STANLEYHALL@GMAIL.COM",
                    FirstName = "Stanley",
                    LastName = "Hall",
                    Designation = "Safety Inspector",
                    EmployeeID = 1243,
                    UserName = "stanleyhall@gmail.com",
                    NormalizedUserName = "STANLEYHALL@GMAIL.COM",
                    PhoneNumber = "63960815",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "f53bf9d9-95d1-42af-804e-e5edacdc9c74",
                    Email = "elenareed@gmail.com",
                    NormalizedEmail = "ELENAREED@GMAIL.COM",
                    FirstName = "Elena",
                    LastName = "Reed",
                    Designation = "Safety Inspector",
                    EmployeeID = 1953,
                    UserName = "elenareed@gmail.com",
                    NormalizedUserName = "ELENAREED@GMAIL.COM",
                    PhoneNumber = "63450508",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser // 5
                {
                    Id = "5258daf7-0bf7-4460-a854-4b3f427312c7",
                    Email = "warrenyoung@gmail.com",
                    NormalizedEmail = "WARRENYOUNG@GMAIL.COM",
                    FirstName = "Warren",
                    LastName = "Young",
                    Designation = "Safety Inspector",
                    EmployeeID = 1331,
                    UserName = "warrenyoung@gmail.com",
                    NormalizedUserName = "WARRENYOUNG@GMAIL.COM",
                    PhoneNumber = "63388585",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "e7b4016a-fa59-4669-969f-36601182f51c",
                    Email = "kevinjones@gmail.com",
                    NormalizedEmail = "KEVINJONES@GMAIL.COM",
                    FirstName = "Kevin",
                    LastName = "Jones",
                    Designation = "Safety Manager",
                    EmployeeID = 1991,
                    UserName = "kevinjones@gmail.com",
                    NormalizedUserName = "KEVINJONES@GMAIL.COM",
                    PhoneNumber = "68999888",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "cda313e3-33c1-4e6e-982b-3c5eb9ff9565",
                    Email = "bobbybrooks@gmail.com",
                    NormalizedEmail = "BOBBYBROOKS@GMAIL.COM",
                    FirstName = "Bobby",
                    LastName = "Brooks",
                    Designation = "Safety Inspector",
                    EmployeeID = 1507,
                    UserName = "bobbybrooks@gmail.com",
                    NormalizedUserName = "BOBBYBROOKS@GMAIL.COM",
                    PhoneNumber = "62570046",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "8d06620d-3d31-4c1c-9449-7eaac032f6bd",
                    Email = "jennielow@gmail.com",
                    NormalizedEmail = "JENNIELOW@GMAIL.COM",
                    FirstName = "Jennie",
                    LastName = "Low",
                    Designation = "Safety Manager",
                    EmployeeID = 1748,
                    UserName = "jennielow@gmail.com",
                    NormalizedUserName = "JENNIELOW@GMAIL.COM",
                    PhoneNumber = "62247473",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "77ea0c8c-fa62-4e13-980a-63ed5336f0b2",
                    Email = "constancelee@gmail.com",
                    NormalizedEmail = "CONSTANCELEE@GMAIL.COM",
                    FirstName = "Constance",
                    LastName = "Lee",
                    Designation = "Safety Inspector",
                    EmployeeID = 1483,
                    UserName = "constancelee@gmail.com",
                    NormalizedUserName = "CONSTANCELEE@GMAIL.COM",
                    PhoneNumber = "67457717",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser // 10
                {
                    Id = "d4d4ebdf-dfc1-4f10-98a9-ba0a3140d563",
                    Email = "bendanis@gmail.com",
                    NormalizedEmail = "BENDANIS@GMAIL.COM",
                    FirstName = "Ben",
                    LastName = "Danis",
                    Designation = "Safety Inspector",
                    EmployeeID = 2024,
                    UserName = "bendanis@gmail.com",
                    NormalizedUserName = "BENDANIS@GMAIL.COM",
                    PhoneNumber = "68626846",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "b57e892b-0bdb-4469-afd9-e6522fea2f25",
                    Email = "jimmybaker@gmail.com",
                    NormalizedEmail = "JIMMYBAKER@GMAIL.COM",
                    FirstName = "Jimmy",
                    LastName = "Baker",
                    Designation = "Safety Inspector",
                    EmployeeID = 2156,
                    UserName = "jimmybaker@gmail.com",
                    NormalizedUserName = "JIMMYBAKER@GMAIL.COM",
                    PhoneNumber = "67789981",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "fe8964fa-aac1-4db1-97bb-017e0905242f",
                    Email = "jakehoward@gmail.com",
                    NormalizedEmail = "JAKEHOWARD@GMAIL.COM",
                    FirstName = "Jake",
                    LastName = "Howard",
                    Designation = "Safety Inspector",
                    EmployeeID = 1397,
                    UserName = "jakehoward@gmail.com",
                    NormalizedUserName = "JAKEHOWARD@GMAIL.COM",
                    PhoneNumber = "62678901",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "33a4bc04-9b10-49a5-8cb6-8dea48b122c4",
                    Email = "ninachoo@gmail.com",
                    NormalizedEmail = "NINACHOO@GMAIL.COM",
                    FirstName = "Nina",
                    LastName = "Choo",
                    Designation = "Safety Inspector",
                    EmployeeID = 1170,
                    UserName = "ninachoo@gmail.com",
                    NormalizedUserName = "NINACHOO@GMAIL.COM",
                    PhoneNumber = "65366623",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "1519fcce-c355-4cad-8b22-01b76b762ffc",
                    Email = "tommyjones@gmail.com",
                    NormalizedEmail = "TOMMYJONES@GMAIL.COM",
                    FirstName = "Tommy",
                    LastName = "Jones",
                    Designation = "Safety Inspector",
                    EmployeeID = 1886,
                    UserName = "tommyjones@gmail.com",
                    NormalizedUserName = "TOMMYJONES@GMAIL.COM",
                    PhoneNumber = "65325334",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser // 15
                {
                    Id = "63929151-0e12-4c5c-a03c-01c34642856a",
                    Email = "elizaross@gmail.com",
                    NormalizedEmail = "ELIZAROSS@GMAIL.COM",
                    FirstName = "Eliza",
                    LastName = "Ross",
                    Designation = "Safety Inspector",
                    EmployeeID = 1140,
                    UserName = "elizaross@gmail.com",
                    NormalizedUserName = "ELIZAROSS@GMAIL.COM",
                    PhoneNumber = "67780373",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "2b94ec41-0ab6-4151-8a0f-3aeb25608ea5",
                    Email = "benjaminscott@gmail.com",
                    NormalizedEmail = "BENJAMINSCOTT@GMAIL.COM",
                    FirstName = "Benjamin",
                    LastName = "Scott",
                    Designation = "Safety Manager",
                    EmployeeID = 1794,
                    UserName = "benjaminscott@gmail.com",
                    NormalizedUserName = "BENJAMINSCOTT@GMAIL.COM",
                    PhoneNumber = "62610071",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "5fe7b4d7-7dd2-4667-b1a0-8d9200a15b28",
                    Email = "kylethomas@gmail.com",
                    NormalizedEmail = "KYLETHOMAS@GMAIL.COM",
                    FirstName = "Kyle",
                    LastName = "Thomas",
                    Designation = "Safety Inspector",
                    EmployeeID = 1426,
                    UserName = "kylethomas@gmail.com",
                    NormalizedUserName = "KYLETHOMAS@GMAIL.COM",
                    PhoneNumber = "67361183",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "e5e8acfe-c59a-4b4d-bba4-d40057aecef4",
                    Email = "maddietay@gmail.com",
                    NormalizedEmail = "MADDIETAY@GMAIL.COM",
                    FirstName = "Maddie",
                    LastName = "Tay",
                    Designation = "Safety Inspector",
                    EmployeeID = 1224,
                    UserName = "maddietay@gmail.com",
                    NormalizedUserName = "MADDIETAY@GMAIL.COM",
                    PhoneNumber = "63457266",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "6f84b324-5cc8-48b6-a348-57c74b3d5294",
                    Email = "larryparker@gmail.com",
                    NormalizedEmail = "LARRYPARKER@GMAIL.COM",
                    FirstName = "Larry",
                    LastName = "Parker",
                    Designation = "Safety Inspector",
                    EmployeeID = 2144,
                    UserName = "larryparker@gmail.com",
                    NormalizedUserName = "LARRYPARKER@GMAIL.COM",
                    PhoneNumber = "67771504",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                new ApplicationUser // 20
                {
                    Id = "911dd5ac-5093-444e-bd8d-b6fed36dcada",
                    Email = "emilybrown@gmail.com",
                    NormalizedEmail = "EMILYBROWN@GMAIL.COM",
                    FirstName = "Emily",
                    LastName = "Brown",
                    Designation = "Safety Manager",
                    EmployeeID = 1061,
                    UserName = "emilybrown@gmail.com",
                    NormalizedUserName = "EMILYBROWN@GMAIL.COM",
                    PhoneNumber = "67528856",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                }
            );
        }
    }
}
