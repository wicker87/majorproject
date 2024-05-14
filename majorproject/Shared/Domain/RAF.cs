using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RAF : BaseDomainModel
    {
        public string? Department { get; set; }
        public string? Process {  get; set; }
        public string? Location {  get; set; }
        public DateTime AssessmentDate {  get; set; }
        public DateTime LastReviewDate { get; set; }
        public DateTime NextReviewDate { get; set;}
    }
}
