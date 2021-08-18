using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManager.DAOs
{
    static internal class DAOMethods
    {
        static internal SqlCommand SqlCommandGenerator(SqlConnection connection, string commandText)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = commandText;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            return sqlCommand;
        }

        static internal SqlParameter SqlParameterGeneratorString(string s, string parameterName )
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.SqlDbType = SqlDbType.NVarChar;
            sqlParameter.SqlValue = s;
            sqlParameter.ParameterName = parameterName;
            return sqlParameter;
        }

        static internal SqlParameter SqlParameterGeneratorInt(int n, string parameterName)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.SqlDbType = SqlDbType.Int;
            sqlParameter.SqlValue = n;
            sqlParameter.ParameterName = parameterName;
            return sqlParameter;
        }

        static internal SqlParameter SqlParameterGeneratorTimeSpan(TimeSpan time, string parameterName)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.SqlDbType = SqlDbType.Time;
            sqlParameter.SqlValue = time;
            sqlParameter.ParameterName = parameterName;
            return sqlParameter;
        }
    }
}
