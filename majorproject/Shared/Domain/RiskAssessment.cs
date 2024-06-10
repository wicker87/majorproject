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
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Department { get; set; }
        [Required]
        public string? Process {  get; set; }
        [Required]
        public string? Location {  get; set; }
        public DateTime AssessmentDate {  get; set; }
        public DateTime LastReviewDate { get; set; }
        public DateTime NextReviewDate { get; set;}

        public string? Approver { get; set; }
        public DateTime ApprovalDate { get; set; }
        [Required]
        public int? TeamId { get; set; }
        public virtual RiskTeam? Team { get; set; }

        public virtual List<WorkActivity>? WorkActivities { get; set; }
    }
}
