using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskEvaluation : BaseDomainModel
    {
        public string? ExistingRiskControls{ get; set; }
        public int? Severity { get; set; }
        public int? Likelihood { get; set; }
        public int? RPN { get; set; }
        public int RiskCID { get; set; }
        public virtual RiskControl? RiskControl { get; set; }

    }
}
