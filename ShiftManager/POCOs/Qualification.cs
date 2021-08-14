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

        public Qualification( string name)
        {
            Name = name;
        }

        public Qualification(string name, int id)
        {
            Id = id;
            Name = name;
        }

        internal Qualification GetQualification()
        {
            throw new NotImplementedException();
        }

        internal void AddQualification(Qualification qualification)
        {
            throw new NotImplementedException();
        }

        internal void EditQualification(Qualification qualification)
        {
            throw new NotImplementedException();
        }

        internal void DeleteQualification(Qualification qualification)
        {
            throw new NotImplementedException();
        }
    }
}
