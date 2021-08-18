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
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "ADD_SHIFT");

                SqlParameter dayOfWeekParameter = DAOMethods.SqlParameterGeneratorInt((int)t.dayOfWeek, "@DAY");
                SqlParameter shiftStartParameter = DAOMethods.SqlParameterGeneratorTimeSpan(t.shiftStart, "@START");
                SqlParameter shiftEndParameter = DAOMethods.SqlParameterGeneratorTimeSpan(t.shiftEnd, "@END");
                SqlParameter qualficationParameter = DAOMethods.SqlParameterGeneratorInt(t.requiredQualification.Id, "@REQ");

                sqlCommand.Parameters.Add(dayOfWeekParameter);
                sqlCommand.Parameters.Add(shiftStartParameter);
                sqlCommand.Parameters.Add(shiftEndParameter);
                sqlCommand.Parameters.Add(qualficationParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public Shift Get(int id)
        {
            Shift shift = new Shift();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "GET_SHIFT_BY_ID");

                SqlParameter idparameter = DAOMethods.SqlParameterGeneratorInt(id, "@ID");

                sqlCommand.Parameters.Add(idparameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

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
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "DELETE_SHIFT");

                SqlParameter idParameter = DAOMethods.SqlParameterGeneratorInt(t.id, "@ID");

                sqlCommand.Parameters.Add(idParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Update(Shift t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "ADD_SHIFT");

                SqlParameter idParameter = DAOMethods.SqlParameterGeneratorInt(t.id, "@ID");
                SqlParameter dayOfWeekParameter = DAOMethods.SqlParameterGeneratorInt((int)t.dayOfWeek, "@DAY");
                SqlParameter shiftStartParameter = DAOMethods.SqlParameterGeneratorTimeSpan(t.shiftStart, "@START");
                SqlParameter shiftEndParameter = DAOMethods.SqlParameterGeneratorTimeSpan(t.shiftEnd, "@END");
                SqlParameter qualficationParameter = DAOMethods.SqlParameterGeneratorInt(t.requiredQualification.Id, "@REQ");

                sqlCommand.Parameters.Add(idParameter);
                sqlCommand.Parameters.Add(dayOfWeekParameter);
                sqlCommand.Parameters.Add(shiftStartParameter);
                sqlCommand.Parameters.Add(shiftEndParameter);
                sqlCommand.Parameters.Add(qualficationParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }
    }
}
