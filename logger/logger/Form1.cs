using System.Net;
using System.Windows.Forms;

namespace logger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void form1_load (object sender, EventArgs e)
        {
            pictureBox1.Visible= true;
            this.TopMost= true;
            Form form = new Form();
            form.Text = "Location";
            Point point = form.Location;
            this.Show();
        }
    }
}