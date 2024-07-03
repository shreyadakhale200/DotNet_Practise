namespace UserEntryForm;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Password_textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void Submit_button1_Click(object sender, EventArgs e)
    {
        string Username = Username_textBox1.Text;
        string Password = Password_textBox2.Text;
        string result = DatabaseConnection.InsertRecord(Username, Password);
        Result_label2.Text = result.ToString();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void Update_button1_Click(object sender, EventArgs e)
    {
        string Username = Username_textBox1.Text;
        string Password = Password_textBox2.Text;
        string result = DatabaseConnection.UpdateRecord(Username, Password);
        Result_label2.Text = result.ToString();
    }

    private void Delete_button1_Click(object sender, EventArgs e)
    {
        //Password_textBox2.Enabled = false;
        string Username = Username_textBox1.Text;
        string result = DatabaseConnection.DeleteRecord(Username);
        Result_label2.Text = result.ToString();
    }
}
