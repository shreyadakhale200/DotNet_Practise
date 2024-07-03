using System.Windows.Forms;

namespace WindowsFormPaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            MessageBox.Show("Hello", "")
        }
    }
}
