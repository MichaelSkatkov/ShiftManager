using ShiftManager.POCOs;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ShiftManager.DAOs.MSSQL
{
    class WorkerDAO : IWorkerDAO
    {
        public void Add(Worker t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "ADD_WORKER");

                SqlParameter nameParameter = DAOMethods.SqlParameterGeneratorString(t.Name, "@NAME");
               
                sqlCommand.Parameters.Add(nameParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public Worker Get(int id)
        {
            Worker worker = new Worker();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "GET_WORKER_BY_ID");

                SqlParameter idParameter = DAOMethods.SqlParameterGeneratorInt(id, "@ID");

                sqlCommand.Parameters.Add(idParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read() == true)
                {
                    worker = new Worker((string)sqlDataReader["NAME"],
                                        (int)sqlDataReader["ID"]);
                }
                connection.Close();
            }
            return worker;
        }

        public IList<Worker> GetAll()
        {
            List<Worker> workers = new List<Worker>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "GET_ALL_WORKERS");
                
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read() == true)
                {
                    Worker worker = new Worker((string)sqlDataReader["NAME"], 
                                               (int)sqlDataReader["ID"]);
                    workers.Add(worker);
                }
                connection.Close();
            }
            return workers;
        }
               
        public void Remove(Worker t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "DELETE_WORKER");

                SqlParameter idParameter = DAOMethods.SqlParameterGeneratorInt(t.Id, "@ID");

                sqlCommand.Parameters.Add(idParameter);

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
        }

        public void Update(Worker t)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLConnectionString"].ConnectionString))
            {
                SqlCommand sqlCommand = DAOMethods.SqlCommandGenerator(connection, "UPDATE_WORKER");

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
