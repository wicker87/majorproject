using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace majorproject.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Designation { get; set; }
        public int EmployeeID { get; set; }


    }
}
