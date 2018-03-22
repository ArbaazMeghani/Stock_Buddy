using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

class DatabaseManager
{
    private const String CONN_STRING = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=./WatchList.mdf;Integrated Security = True";

    public DatabaseManager() { }

    private SqlCommand Connect(String query)
    {
        SqlConnection sqlConnection = new SqlConnection(CONN_STRING);
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        sqlConnection.Open();
        return sqlCommand;
    }

    private void Disconnect(SqlConnection connection)
    {
        connection.Close();
    }

    private void ScalarQuery(String query)
    {
        SqlCommand command = Connect(query);
        command.ExecuteNonQuery();
        Disconnect(command.Connection);
    }
}
