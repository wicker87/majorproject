using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Employee : BaseDomainModel
    {
        [Required]
        public string? Photo { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"6\d{7}", ErrorMessage = "This is not a valid phone number")]
        public string? PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        [Required]
        public string? Designation {  get; set; }

        [Required]
        [Range(1000, 2200, ErrorMessage = "ID number not within range")]
        public int EmployeeID { get; set;} // 4-digits
    }
}
