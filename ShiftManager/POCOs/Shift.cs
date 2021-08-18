using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShiftManager.POCOs
{
    internal class Shift :IPOCO
    {
        int id { get; set; }
        int requiredQualification { get; set; }
        internal TimeSpan shiftStart { get; set; } = new TimeSpan(0, 0, 1);
        internal TimeSpan shiftEnd { get; set; } = new TimeSpan(0, 0, 2);
        internal DayOfWeek dayOfWeek { get; set; }

        public Shift()
        {

        }
        public Shift(int qualification, int id = 0) : this()
        {
            this.requiredQualification = qualification;
            this.id = id;
        }

        public Shift(int qualification, DayOfWeek day, int id = 0) : this (qualification,id)
        {
            this.dayOfWeek = day;
        }

        public Shift(int qualification, TimeSpan start, TimeSpan end, DayOfWeek day, int id = 0) : this (qualification, day, id)
        {
            this.shiftStart = start;
            this.shiftEnd = end;
        }
    }
}
