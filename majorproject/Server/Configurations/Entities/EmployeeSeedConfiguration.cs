using majorproject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

// EmployeeId 2,6,8,20 (Project Manager) 
namespace majorproject.Server.Configurations.Entities
{
    public class EmployeeSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Jane Doe",
                    DateOfBirth = new DateTime(1990, 5, 20),
                    Gender = "Female",
                    PhoneNumber = "64841415",
                    EmailAddress = "janedoe@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1003,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 2,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "John Smith",
                    DateOfBirth = new DateTime(1985, 8, 15),
                    Gender = "Male",
                    PhoneNumber = "67349033",
                    EmailAddress = "johnsmith@gmail.com",
                    Designation = "Project Manager",
                    EmployeeID = 2010,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 3,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Stanley Hall",
                    DateOfBirth = new DateTime(1976, 2, 14),
                    Gender = "Male",
                    PhoneNumber = "63960815",
                    EmailAddress = "stanleyhall@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1243,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 4,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Elena Reed",
                    DateOfBirth = new DateTime(1994, 7, 22),
                    Gender = "Female",
                    PhoneNumber = "63450508",
                    EmailAddress = "elenareed@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1953,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 5,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Warren Young",
                    DateOfBirth = new DateTime(1981, 11, 4),
                    Gender = "Male",
                    PhoneNumber = "63388585",
                    EmailAddress = "warrenyoung@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1331,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 6,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Kevin Jones",
                    DateOfBirth = new DateTime(1979, 7, 28),
                    Gender = "Male",
                    PhoneNumber = "68999888",
                    EmailAddress = "kevinjones@gmail.com",
                    Designation = "Project Manager",
                    EmployeeID = 1991,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 7,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Bobby Brooks",
                    DateOfBirth = new DateTime(1989, 3, 1),
                    Gender = "Male",
                    PhoneNumber = "62570046",
                    EmailAddress = "bobbybrooks@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1507,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 8,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Jennie Low",
                    DateOfBirth = new DateTime(1991, 2, 2),
                    Gender = "Female",
                    PhoneNumber = "62247473",
                    EmailAddress = "jennielow@gmail.com",
                    Designation = "Project Manager",
                    EmployeeID = 1748,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 9,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Constance Lee",
                    DateOfBirth = new DateTime(1997, 2, 9),
                    Gender = "Female",
                    PhoneNumber = "67457717",
                    EmailAddress = "constancelee@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1483,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 10,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Ben Danis",
                    DateOfBirth = new DateTime(1986, 3, 16),
                    Gender = "Male",
                    PhoneNumber = "68626846",
                    EmailAddress = "bendanis@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 2024,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 11,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Jimmy Baker",
                    DateOfBirth = new DateTime(1979, 9, 21),
                    Gender = "Male",
                    PhoneNumber = "67789981",
                    EmailAddress = "jimmybaker@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 2156,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 12,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Jake Howard",
                    DateOfBirth = new DateTime(1993, 6, 22),
                    Gender = "Male",
                    PhoneNumber = "62678901",
                    EmailAddress = "jakehoward@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1397,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 13,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Nina Choo",
                    DateOfBirth = new DateTime(1986, 5, 23),
                    Gender = "Female",
                    PhoneNumber = "65366623",
                    EmailAddress = "ninachoo@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1170,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 14,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Tommy Jones",
                    DateOfBirth = new DateTime(1981, 12, 16),
                    Gender = "Male",
                    PhoneNumber = "65325334",
                    EmailAddress = "tommyjones@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1886,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 15,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Eliza Ross",
                    DateOfBirth = new DateTime(1996, 4, 24),
                    Gender = "Female",
                    PhoneNumber = "67780373",
                    EmailAddress = "elizaross@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1140,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 16,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Benjamin Scott",
                    DateOfBirth = new DateTime(1977, 5, 7),
                    Gender = "Male",
                    PhoneNumber = "62610071",
                    EmailAddress = "benjaminscott@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1794,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 17,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Kyle Thomas",
                    DateOfBirth = new DateTime(1996, 9, 30),
                    Gender = "Male",
                    PhoneNumber = "67361183",
                    EmailAddress = "kylethomas@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1426,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 18,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Maddie Tay",
                    DateOfBirth = new DateTime(1991, 2, 8),
                    Gender = "Female",
                    PhoneNumber = "63457266",
                    EmailAddress = "maddietay@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 1224,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 19,

                    Photo = GetImageData("Images/mprofile.jpg"),
                    FullName = "Larry Parker",
                    DateOfBirth = new DateTime(1985, 1, 26),
                    Gender = "Male",
                    PhoneNumber = "67771504",
                    EmailAddress = "larryparker@gmail.com",
                    Designation = "Safety Inspector",
                    EmployeeID = 2144,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Employee
                {
                    Id = 20,

                    Photo = GetImageData("Images/fprofile.jpg"),
                    FullName = "Emily Brown",
                    DateOfBirth = new DateTime(1992, 3, 10),
                    Gender = "Female",
                    PhoneNumber = "67528856",
                    EmailAddress = "emilybrown@gmail.com",
                    Designation = "Project Manager",
                    EmployeeID = 1061,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }

        // Helper method to convert an image file to a base64 string
        private static string GetImageData(string imagePath)
        {
            using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    byte[] imageBytes = memoryStream.ToArray();
                    return Convert.ToBase64String(imageBytes);
                }
            }
        }
    }
}
