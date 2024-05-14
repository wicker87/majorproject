using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskTeam : BaseDomainModel
    {
        public int? LeaderId { get; set; }
        public virtual Employee? Leader { get; set; }

        public int? Member1Id { get; set; }
        public virtual Employee? Member1 { get; set; }

        public int? Member2Id { get; set; }
        public virtual Employee? Member2 { get; set; }

        public int? Member3Id { get; set; }
        public virtual Employee? Member3 { get; set; }

        public int? Member4Id { get; set; }
        public virtual Employee? Member4 { get; set; }

        public int? Member5Id { get; set; }
        public virtual Employee? Member5 { get; set; }

        public int? FormId { get; set; }
        public virtual RAF? RAF { get; set; }
    }
}
