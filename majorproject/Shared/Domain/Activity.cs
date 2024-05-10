using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorproject.Shared.Domain
{
    public class Activity:BaseDomainModel
    {
        public string? WorkActivity {  get; set; }
        public int FormID {  get; set; }
        public virtual RAF? RAF { get; set; }
    }
}
