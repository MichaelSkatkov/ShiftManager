using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShiftManager.POCOs
{
    internal class Shift :IPOCO
    {
        internal TimeSpan ShiftStart { get; set; } = new TimeSpan(0, 0, 1);
        internal TimeSpan ShiftEnd { get; set; } = new TimeSpan(0, 0, 2);
        internal DayOfWeek Day { get; set; }

        public Shift(DayOfWeek day)
        {
            this.Day = day;
        }

        public Shift(TimeSpan start, TimeSpan end, DayOfWeek day)
        {
            this.ShiftStart = start;
            this.ShiftEnd = end;
            this.Day = day;
        }
    }
}
