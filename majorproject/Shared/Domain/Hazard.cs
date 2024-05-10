using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Hazard: BaseDomainModel
    {
        public string? HazardName { get; set; }
        public string? PossibleInjury {  get; set; }
        public int WorkID {  get; set; }
        public virtual Activity? Activity {  get; set; }
        public int RiskEID {  get; set; }
        public virtual RiskEvaluation? RiskEvaluation { get; set; }

    }
}
