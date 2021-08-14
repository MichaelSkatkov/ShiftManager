using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftManager.POCOs;

namespace ShiftManager.DAOs
{
    internal interface IBasicDAO<T> where T : IPOCO
    {
        T Get(int id);
        IList<T> GetAll();
        void Add(T t);
        void Remove(T t);
        void Update(T t);

    }
}
