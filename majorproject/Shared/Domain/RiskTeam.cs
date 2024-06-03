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
        public string? Leader { get; set; }

        public string? Member1 { get; set; }

        public string? Member2 { get; set; }

        public string? Member3 { get; set; }

        public string? Member4 { get; set; }

        public string? Member5 { get; set; }
    }
}
