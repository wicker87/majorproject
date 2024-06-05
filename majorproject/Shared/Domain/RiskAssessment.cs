using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskAssessment : BaseDomainModel
    {
        public bool? ApprovedStatus { get; set; }

        public string? Name { get; set; }
        public string? Department { get; set; }
        public string? Process {  get; set; }
        public string? Location {  get; set; }
        public DateTime AssessmentDate {  get; set; }
        public DateTime LastReviewDate { get; set; }
        public DateTime NextReviewDate { get; set;}

        public int? TeamId { get; set; }
        public virtual RiskTeam? RiskTeam { get; set; }

        public string? Approver { get; set; }
        public DateTime ApprovalDate { get; set; }

        public virtual ICollection<Activity>? Activities { get; set; }
    }
}
