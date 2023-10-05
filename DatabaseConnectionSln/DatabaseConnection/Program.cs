namespace DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (ConnectionAccessor.TestDatabaseConnection())
            {
                // Database connection is successful. You can perform your database operations here.
            }
            else
            {
                // Database connection failed.
                Console.WriteLine("Unable to connect to the database.");
            }
        }
    }
}