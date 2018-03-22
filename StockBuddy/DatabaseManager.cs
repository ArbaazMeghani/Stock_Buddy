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
    private const String CONN_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WatchList.mdf;Integrated Security=True";

    public DatabaseManager() { }

    private SqlCommand Connect(String query)
    {
        SqlConnection sqlConnection = new SqlConnection(CONN_STRING);
        SqlCommand command = new SqlCommand(query, sqlConnection);
        Console.WriteLine(CONN_STRING);
        sqlConnection.Open();
        return command;
    }

    public void SimpleQueryExecution(String query)
    {
        SqlCommand command = Connect(query);
        NonQuery(command);
    }

    public void UpdateTableItem(String symbol, String query)
    {
        SqlCommand command = Connect(query);
        command.Parameters.AddWithValue("@Symbol", symbol);
        NonQuery(command);
    }

    public void UpdatePurchaseListItem(String symbol, int quantity, double price, String query)
    {
        SqlCommand command = Connect(query);
        command.Parameters.AddWithValue("@Symbol", symbol);
        command.Parameters.AddWithValue("@Quantity", quantity);
        command.Parameters.AddWithValue("@Price", price);
        NonQuery(command);
    }

    public DataTable SelectQuery(String query)
    {
        DataTable dataTable = new DataTable();
        SqlCommand command = Connect(query);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        dataAdapter.Fill(dataTable);
        Disconnect(command.Connection);
        return dataTable;
    }

    private void Disconnect(SqlConnection connection)
    {
        connection.Close();
    }

    private void NonQuery(SqlCommand command)
    {
        command.ExecuteNonQuery();
        Disconnect(command.Connection);
    }
}
