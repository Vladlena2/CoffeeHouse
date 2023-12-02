using Npgsql;
using System;
using System.Data;

public class DatabaseHelper
{
    private static readonly string connectionString = "Host=localhost;Port=5432;Database=Coffeehouse;Username=postgres;Password=1234";
    NpgsqlConnection conn = new NpgsqlConnection(connectionString);

    public void openConnection()
    {
        //Если связь закрыта 
        if (conn.State == System.Data.ConnectionState.Closed) 
        {
            conn.Open();
        }
        
    }

    public void closeConnection()
    {
        //Если связь закрыта 
        if (conn.State == System.Data.ConnectionState.Open) { }
        conn.Close();
    }

    // Метод для выполнения SQL-запроса и обработки результатов
    public void ExecuteQuery(string query, Action<NpgsqlDataReader> processRow)
    {
        
    }

    public NpgsqlConnection getConnection()
    {
        return conn;
    }
}
