using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class ImageSource:BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public long? Size { get; set; }
        public string? Base64String { get; set; }
        public string? PromptAnswer {  get; set; }
        public int? AssessmentId { get; set; }
        public virtual RiskAssessment? Assessment { get; set; }
        

    }
}
