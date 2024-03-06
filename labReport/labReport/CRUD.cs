using System;
using MySql.Data.MySqlClient;

namespace labReport
{
    internal class CRUD
    {
        static void Main()
        {
            string connectionString = 
                "Server=localhost;Port=3306;Database=dotnetcrud;User=root;Password=Cham123@;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }
            
    }
}
