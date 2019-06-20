using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timmy.ClassFile;

namespace Timmy.Forms
{
    public partial class Animation : Form
    {
        MainForm main = (MainForm)Singleton.getMainInstance();
        Graphics drawString;
        private string text;
        
        public Animation()
        {
            InitializeComponent();
            drawString = pictureBox2.CreateGraphics();
            
        }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            picturSeBox1.Location = new Point(picturSeBox1.Location.X + 3, 143);
            drawString.DrawString(main.resultbox.Text, Font, Brushes.SkyBlue, new Point(43, 97));
            pictureBox2.Location = new Point(pictureBox2.Location.X + 3, 71);
            
            if (picturSeBox1.Location.X > this.Size.Width)

            {
                picturSeBox1.Location = new Point(1, picturSeBox1.Location.Y);
                pictureBox2.Location = new Point(1, pictureBox2.Location.Y);
            }
           
        }
      
        public void anitext(string text)
        {
            this.text = text;
            Console.WriteLine(text + "\t애니메이션");
            
            drawString.DrawString(text, Font, Brushes.SkyBlue, new Point(43, 97));
            tbxResult.Text = text;
        }

        private void Animation_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }/*
        protected override void OnPaint(PaintEventArgs e)
        {
            textBox1.Text = main.resultbox.Text;
            using (Font myFont = new Font("Arial", 10))
            {
                e.Graphics.DrawString(textBox1.Text, myFont, Brushes.Green, new Point(43, 97));
            }
        }
        *//*
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            drawString.DrawString(textBox1.Text, Font, Brushes.SkyBlue, new Point(43, 97)); 
        }*/
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
