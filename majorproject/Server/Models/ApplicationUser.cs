using Microsoft.AspNetCore.Identity;

namespace majorproject.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? position { get; set; }

    }
}
