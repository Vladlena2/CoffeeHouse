using Npgsql;
using System;
using System.Data;

public class DatabaseHelper
{
    private readonly string connectionString;

    // Конструктор класса, принимающий строку подключения к базе данных
    public DatabaseHelper()
    {
        this.connectionString = "Host=localhost;Port=5432;Database=Coffeehouse;Username=postgres;Password=1234";
    }

    // Метод для выполнения SQL-запроса и обработки результатов
    public void ExecuteQuery(string query, Action<NpgsqlDataReader> processRow)
    {
        // Используем using для гарантированного закрытия соединения даже в случае исключения
        using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
        {
            // Открываем соединение с базой данных
            conn.Open();

            // Создаем команду для выполнения SQL-запроса
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                // Используем using для автоматического закрытия читателя данных
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    // Читаем результаты запроса построчно
                    while (reader.Read())
                    {
                        // Вызываем переданный делегат для обработки каждой строки результата
                        processRow?.Invoke(reader);
                    }
                }
            }
        }
    }
}
