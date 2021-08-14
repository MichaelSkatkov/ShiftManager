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

        public Worker()
        {

        }

        public Worker(string name, List<Qualification> qualifications, List<Shift> shifts)
        {
            this.Name = name;
            this.ListOfWorkerQualifications = qualifications;
            this.ListOfWeeklyShifts = shifts;
        }

        public Worker(int id, string name, List<Qualification> qualifications)
        {
            this.Id = id;
            this.Name = name;
            this.ListOfWorkerQualifications = qualifications;
        }

        internal Worker GetWorker()
        {
            throw new NotImplementedException();
        }

        internal void AddWorker(Worker worker)
        {
            throw new NotImplementedException();
        }

        internal void EditWorker(Worker worker)
        {
            throw new NotImplementedException();
        }

        internal void DeleteWorker(Worker worker)
        {
            throw new NotImplementedException();
        }
    }
}
