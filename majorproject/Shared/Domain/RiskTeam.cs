using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskTeam:BaseDomainModel
    {
        public string? Lead { get; set; }
        public string? POne { get; set; }
        public string? PTwo { get; set; }
        public string? PThree { get; set; }
        public string? PFour{ get; set; }
        public string? PFive { get; set; }
        public int FormID {  get; set; }
        public virtual RAF? RAF { get; set; }
    }
}
