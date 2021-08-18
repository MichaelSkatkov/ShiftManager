using ShiftManager.POCOs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager.DAOs.MSSQL
{
    class ShiftDAO : IShiftDAO
    {
        public void Add(Shift t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                throw new NotImplementedException();
            }
        }

        public Shift Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                throw new NotImplementedException();
            }
        }

        public IList<Shift> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                throw new NotImplementedException();
            }
        }

        public void Remove(Shift t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                throw new NotImplementedException();
            }
        }

        public void Update(Shift t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                throw new NotImplementedException();
            }
        }
    }
}
