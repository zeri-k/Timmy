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
    public partial class StartForm : Form
    {
        MainForm main;
        SetLoginForm settingForm;
        SetSiteForm listForm;

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if(main == null)
                main = new MainForm();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(300, 150);

            main.Show();
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            Animation ani = new Animation();
            ani.Show();
        }
        

        private void tsmExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            if (settingForm == null)
                settingForm = new SetLoginForm();
            settingForm.Show();
        }

        private void tsmSite_Click(object sender, EventArgs e)
        {
            if (listForm == null)
                listForm = new SetSiteForm();
            listForm.Show();
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            if (main == null)
                main = new MainForm();
            main.Show();
        }

        private void ntfIcon_DoubleClick(object sender, EventArgs e)
        {
            if (main == null)
                main = new MainForm();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
