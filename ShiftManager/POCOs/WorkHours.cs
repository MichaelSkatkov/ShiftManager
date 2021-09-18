using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager.POCOs
{
    class WorkHours
    {
        DateTime startTime { get; set; }
        DateTime endTime { get; set; }

        public WorkHours(DateTime start, DateTime end)
        {
            this.startTime = start;
            this.endTime = end;
        }
    }
}
