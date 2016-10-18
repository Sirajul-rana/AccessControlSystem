using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Framework
{
    public class DataAccess
    {
        string connectionString = "Data Source=JARVIS;Initial Catalog=AccessControldb;User ID=sa;Password=Deathstrok;Pooling=False";
        public string LoginExecute(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            connection.Open();
            string value = command.ExecuteScalar().ToString();
            connection.Close();
            return value;
        }
    }
}
