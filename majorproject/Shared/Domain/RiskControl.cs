using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskControl : BaseDomainModel
    {
        [Required]
        public string? AdditionalControls { get; set; }
        public int? Severity { get; set; }
        public int? Likelihood { get; set; }
        public int? RPN { get; set; }
        public string? ImplementingPerson { get; set; }
        public DateTime DueDate { get; set; }
        public string? Remarks { get; set; }
        public int? EvaluationId { get; set; }
        public virtual RiskEvaluation? Evaluation { get; set; }

    }
}
