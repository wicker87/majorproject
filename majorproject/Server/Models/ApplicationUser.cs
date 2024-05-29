using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace majorproject.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }


    }
}
