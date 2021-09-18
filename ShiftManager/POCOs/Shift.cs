using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShiftManager.POCOs
{
    internal class Shift :IPOCO
    {
        internal int id { get; }
        internal int qualificationId { get; set; }
        internal Qualification requiredQualification { get; set; }
        internal TimeSpan shiftStart { get; set; } = new TimeSpan(0, 0, 1);
        internal TimeSpan shiftEnd { get; set; } = new TimeSpan(0, 0, 2);
        internal DayOfWeek dayOfWeek { get; set; }

        public Shift()
        {

        }
        public Shift(int qualificationId, int id = 0) : this()
        {
            this.qualificationId = qualificationId;
            this.id = id;
        }

        public Shift(int qualificationId, DayOfWeek day, int id = 0) : this (qualificationId, id)
        {
            this.dayOfWeek = day;
        }

        public Shift(int qualificationId, TimeSpan start, TimeSpan end, DayOfWeek day, int id = 0) : this (qualificationId, day, id)
        {
            this.shiftStart = start;
            this.shiftEnd = end;
        }
    }
}
