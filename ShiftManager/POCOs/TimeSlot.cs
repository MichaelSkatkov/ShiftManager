using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager.POCOs
{
    internal class TimeSlot : IPOCO
    {
        internal int Id { get; set; }
        internal DayOfWeek DayOfWeek { get; set; }
    }
}
