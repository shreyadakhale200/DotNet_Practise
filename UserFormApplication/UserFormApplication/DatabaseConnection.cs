using MySql.Data.MySqlClient;
namespace UserFormApplication
{
    public static class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Port=3306;Database=Movies;User=root;Password=Shrey@root18;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
