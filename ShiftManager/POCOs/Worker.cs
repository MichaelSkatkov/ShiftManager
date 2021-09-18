using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager.POCOs
{
    internal class Worker : IPOCO
    {
        internal int Id { get;  }
        internal string Name { get; set; }
        internal List<Qualification> ListOfWorkerQualifications { get; set; }
        internal List<Shift> ListOfWeeklyShifts { get; set; }
        internal Dictionary<DayOfWeek, WorkHours> WorkHoursByDay;

        public Worker()
        {

        }

        public Worker (string name) : this()
        {
            this.Name = name;
        }

        public Worker(string name, int id = 0) : this(name)
        {
            this.Id = id;
        }
    }
}
