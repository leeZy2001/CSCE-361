using System;
using System.Data.SqlClient;

public class ConnectionAccessor
{
    public static bool TestDatabaseConnection()
    {
        // Connection string - replace with your actual database connection details
        string connectionString =
            "Data Source=LeeZiYang\\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connection successful.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
