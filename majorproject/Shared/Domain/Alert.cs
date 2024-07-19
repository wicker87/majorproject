using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Alert : BaseDomainModel
    {
        public string? Message { get; set; }
        public DateTime DateTime { get; set; }
        public int? AssessmentId { get; set; }
        public virtual RiskAssessment? Assessment { get; set; }      
    }
}
// Basically alert system that can do:
//1) alert when form is created (Create button)
//2) alert when form is approved (Approved button)
//3) alert when form is unapproved (Unapproved button)
// This class to store alerts inside database
// GET and POST method in controller 
// Frontend display data accordingly (Admin, Leader, Members, Manager) similar to assessment list page