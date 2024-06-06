using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Identification : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? PossibleInjury { get; set; }
        public int? ActivityId { get; set; }
        public virtual WorkActivity? Activity { get; set; }
        public virtual List<RiskEvaluation>? RiskEvaluations { get; set; }
    }
}
