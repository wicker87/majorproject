using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskEvaluation : BaseDomainModel
    {
        [Required]
        public string? ExistingRiskControls { get; set; }
        public int? Severity { get; set; }
        public int? Likelihood { get; set; }
        public int? RPN { get; set; }
        public int? HazardId { get; set; }
        public virtual Identification? Hazard { get; set; }
        public virtual RiskControl? Control { get; set; }
    }
}
