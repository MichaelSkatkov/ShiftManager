using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftManager.POCOs;

namespace ShiftManager.DAOs.Methods
{
    interface IWorkerMethod : IMethodBase<Worker>
    {
        void GetWorkerQualifications(Worker worker);
        void UpdateWorkerHours(Worker worker);

            
    }
}
