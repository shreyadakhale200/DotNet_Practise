using MySql.Data.MySqlClient;
namespace UserEntryForm
{
    //For UPDATE, INSERT, and DELETE statements, the return value is the number of rows affected by the command
    public static class DatabaseConnection
    {
        private static string connectionString = "server=localhost;port=3306;password=Shrey@root18;user=root;database=UserInfo;";
        public static MySqlConnection getConnection()
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
        public static string InsertRecord(string Username, string Password)
        {
            MySqlConnection conn = getConnection();
            string query = "insert into user(Username,Password) values(@Username,@Password)";
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.ExecuteNonQuery();
                return "Record Inserted Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string UpdateRecord(string Username, string Password)
        {
            MySqlConnection conn = getConnection();
            string query = "update user set Password=@Password where Username=@Username";
            try
            {

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Username", Username);
                command.ExecuteNonQuery();
                return "Record Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string DeleteRecord(string Username)
        {
            MySqlConnection conn = getConnection();
            string query = "delete from user where Username = @Username";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@Username", Username);
            command.ExecuteNonQuery();
            return "Record Deleted Successfully";
        }

    }
}
