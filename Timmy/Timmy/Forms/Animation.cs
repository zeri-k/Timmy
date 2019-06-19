using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timmy.Forms
{
    public partial class Animation : Form
    {
       // MainForm main = new MainForm();
       // Graphics drawString;
        public Animation()
        {
            InitializeComponent();
           // drawString = pictureBox1.CreateGraphics();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 3, 143);
            pictureBox2.Location = new Point(pictureBox2.Location.X + 3, 71);
            if (pictureBox1.Location.X > this.Size.Width)

            {
                pictureBox1.Location = new Point(1, pictureBox1.Location.Y);
                pictureBox2.Location = new Point(1, pictureBox2.Location.Y);
               
            }
           
        }
      /*
        public void anitext(string text)
        {
            
            string b = textBox1.Text;
            string a = text;
            b = a;
            Console.WriteLine(b);
            drawString.DrawString(a, Font, Brushes.SkyBlue, new Point(43, 97));
            

        }
        */
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
        */
       
        
    }
}
