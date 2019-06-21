using System;
using System.Drawing;
using System.Windows.Forms;
using Timmy.ClassFile;

namespace Timmy.Forms
{
    public partial class Animation : Form
    {
        MainForm main = (MainForm)Singleton.getMainInstance();
        private string text;
        public delegate void dgtSetBox(string result);

        public Animation()
        {
            InitializeComponent();
        }
        private static DateTime Delay(int MS)

        {

            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (tbxResult.Text == text)
            {
                if (picturSeBox1.Location.X + picturSeBox1.Width > this.Size.Width)
                {
                  //  Delay(3000);
                    picturSeBox1.Location = new Point(picturSeBox1.Location.X, 660);
                    tbxResult.Location = new Point(tbxResult.Location.X, 540);
                }

                
            }
            else if(tbxResult.Text=="")
            {
                picturSeBox1.Location = new Point(picturSeBox1.Location.X + 3, 660);
                tbxResult.Location = new Point(tbxResult.Location.X + 3, 540);
            }
            
            if (picturSeBox1.Location.X  > this.Size.Width)

            {
                picturSeBox1.Location = new Point(1, picturSeBox1.Location.Y);
                tbxResult.Location = new Point(1, tbxResult.Location.Y);
            }
           
        }
      
        public void anitext(string text)
        {
            if (this.tbxResult.InvokeRequired)
            {
                dgtSetBox dgt = new dgtSetBox(anitext);
                this.Invoke(dgt, new object[] { text });

                this.text = text;
                Console.WriteLine(text + "\t애니메이션");
                tbxResult.Text = text;
            }
            else
            {
                tbxResult.Text = text;
                if (tbxResult.Text.Equals(text))
                {
                    tbxResult.Visible = true;
                }
            }
        }

        private void tbxResult_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "";
            main.resultbox.Text = "";
            tbxResult.Visible = false;
        }

        private void Animation_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }
    }
}
