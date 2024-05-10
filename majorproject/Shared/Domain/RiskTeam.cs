using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class RiskTeam:BaseDomainModel
    {
        public string? Leader { get; set; }
        public string? MemberOne { get; set; }
        public string? MemberTwo { get; set; }
        public string? MemberThree { get; set; }
        public string? MemberFour{ get; set; }
        public string? MemberFive { get; set; }
        public int FormID {  get; set; }
        public virtual RAF? RAF { get; set; }
    }
}
