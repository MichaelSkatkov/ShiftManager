using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager.POCOs
{
    internal class Qualification : IPOCO
    {
        internal int Id { get; }
        internal string Name { get; set; }
        public Qualification()
        {

        }

        public Qualification(string name) : this()
        {
            Name = name;
        }

        public Qualification(string name, int id = 0) : this(name)
        {
            Id = id;
        }
    }
}
