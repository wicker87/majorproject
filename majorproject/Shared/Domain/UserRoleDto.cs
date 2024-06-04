using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class UserRoleDto 
    {
        public string? UserId { get; set; }
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Designation { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? RoleId { get; set; }
        public string? RoleName { get; set; }
    }
}
