using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class WorkActivity : BaseDomainModel
    {
        public string? Name {  get; set; }
        public int? AssessmentId {  get; set; }
        public virtual RiskAssessment? Assessment { get; set; }
        public virtual List<Identification>? Identifications { get; set; }
    }
}
