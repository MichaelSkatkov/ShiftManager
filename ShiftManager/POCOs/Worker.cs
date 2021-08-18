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

        public Worker (string name) : this()
        {
            this.Name = name;
        }

        public Worker(string name, int id = 0) : this(name)
        {
            this.Id = id;
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
