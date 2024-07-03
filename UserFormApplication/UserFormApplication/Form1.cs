using MySql.Data.MySqlClient;

namespace UserFormApplication
{
    public partial class MoviesFilling_Form1 : Form
    {
        public MoviesFilling_Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlConnection = DatabaseConnection.GetConnection();
            if (sqlConnection != null)
            {
                label2.Text = "Connect Established Successfully";
                sqlConnection.Close();
            }
            else
            {
                label2.Text = "Connection Failed";
            }
        }
    }
}
