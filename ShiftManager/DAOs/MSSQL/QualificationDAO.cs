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
    class QualificationDAO : IQualificationDAO
    {
        public void Add(Qualification t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "ADD_QUALIFICATION");

                SqlParameter nameParameter = DAOMethods.SqlParameterGeneratorString(t.Name, "@NAME");

                sqlCommand.Parameters.Add(nameParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public Qualification Get(int id)
        {
            Qualification qualification = new Qualification();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "GET_QUALIFICATION");

                SqlParameter idParameter = DAOMethods.SqlParameterGeneratorInt(id, "@ID");

                sqlCommand.Parameters.Add(idParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read() == true)
                {
                    qualification = new Qualification((string)sqlDataReader["NAME"],
                                                      (int)sqlDataReader["ID"]);
                }
                connection.Close();
            }
            return qualification;
        }

        public IList<Qualification> GetAll()
        {
            List<Qualification> qualifications = new List<Qualification>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "GET_ALL_QUALIFICATIONS");

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read() == true)
                {
                    Qualification qualification = new Qualification((string)sqlDataReader["NAME"],
                                                                    (int)sqlDataReader["ID"]);
                    qualifications.Add(qualification);
                }
                connection.Close();
            }
            return qualifications;
        }

        public void Remove(Qualification t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "DELETE_QUALIFICATION");

                SqlParameter idParameter = DAOMethods.SqlParameterGeneratorInt(t.Id, "@ID");

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Update(Qualification t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "UPDATE_QUALIFICATION");

                SqlParameter idParameter = DAOMethods.SqlParameterGeneratorInt(t.Id, "@ID");
                SqlParameter nameParameter = DAOMethods.SqlParameterGeneratorString(t.Name, "@NAME");

                sqlCommand.Parameters.Add(idParameter);
                sqlCommand.Parameters.Add(nameParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }
    }
}
