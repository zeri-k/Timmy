using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timmy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.StreamingMicRecognizeAsync(5);
            this.txtView.Text += Program.resultText + "\r\n";
        }

        public void txtView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
