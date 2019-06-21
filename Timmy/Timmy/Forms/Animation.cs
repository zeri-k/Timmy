using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timmy.ClassFile;
using static Timmy.ClassFile.SeleniumDriver;

namespace Timmy.Forms
{
    public partial class Animation : Form
    {
        MainForm main = (MainForm)Singleton.getMainInstance();
        private string text;
        
        public Animation()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tbxResult.Text == text)
            {
                picturSeBox1.Location = new Point(picturSeBox1.Location.X , 143);
                tbxResult.Location = new Point(tbxResult.Location.X , 31);
                

            }
            else if(tbxResult.Text=="")
            {
                picturSeBox1.Location = new Point(picturSeBox1.Location.X + 3, 143);
                tbxResult.Location = new Point(tbxResult.Location.X + 3, 31);
            }
            
            if (picturSeBox1.Location.X > this.Size.Width)

            {
                picturSeBox1.Location = new Point(1, picturSeBox1.Location.Y);
                tbxResult.Location = new Point(1, tbxResult.Location.Y);
            }
           
        }
      
        public void anitext(string text)
        {                this.text = text;
                Console.WriteLine(text + "\t애니메이션");
                tbxResult.Text = text;
                if (tbxResult.Text == text)
                {
                    tbxResult.Visible = true;
                }
            
        }

        private void Animation_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tbxResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxResult_Click(object sender, EventArgs e)
        {

            tbxResult.Text = "";
            main.resultbox.Text = "";
            tbxResult.Visible = false;
        }
    }
}
