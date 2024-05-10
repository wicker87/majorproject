using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Approval : BaseDomainModel
    {
        public bool? Approved { get; set; }
        public string? Name { get;set;}
        public string? Position { get;set;}
        public DateTime? Date { get;set;}
        public int FormID {  get;set;}
        public virtual RAF? RAF { get; set; }


    }
}
