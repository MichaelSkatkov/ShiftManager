using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShiftManager.POCOs
{
    internal class Shift :IPOCO
    {
        internal int id { get; set; }
        internal Qualification requiredQualification { get; set; }
        internal TimeSpan shiftStart { get; set; } = new TimeSpan(0, 0, 1);
        internal TimeSpan shiftEnd { get; set; } = new TimeSpan(0, 0, 2);
        internal DayOfWeek dayOfWeek { get; set; }

        public Shift()
        {

        }
        public Shift(Qualification qualification, int id = 0) : this()
        {
            this.requiredQualification = qualification;
            this.id = id;
        }

        public Shift(Qualification qualification, DayOfWeek day, int id = 0) : this (qualification,id)
        {
            this.dayOfWeek = day;
        }

        public Shift(Qualification qualification, TimeSpan start, TimeSpan end, DayOfWeek day, int id = 0) : this (qualification, day, id)
        {
            this.shiftStart = start;
            this.shiftEnd = end;
        }
    }
}
