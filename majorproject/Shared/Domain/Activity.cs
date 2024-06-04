using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Activity : BaseDomainModel
    {
        public string? Name {  get; set; }
        public int? AssessmentId {  get; set; }
        public virtual RiskAssessment? RiskAssessment { get; set; }
        public virtual ICollection<Hazard>? Hazards { get; set; }
    }
}
