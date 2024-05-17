using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Approval : BaseDomainModel
    {
        public bool? Approved { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfApproval { get;set;}
        public int? FormId { get; set; }
        public virtual RAF? RAF { get; set; }
    }
}
