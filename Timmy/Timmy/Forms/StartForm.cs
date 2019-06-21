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
    public partial class StartForm : Form
    {
        MainForm main = (MainForm)Singleton.getMainInstance();
        SetLoginForm settingForm = (SetLoginForm)Singleton.getSettingFormInstance();
        SetSiteForm listForm = (SetSiteForm)Singleton.getListFormInstance();
        Animation ani = (Animation)Singleton.getAnimationInstance();

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(300, 150);

            main.Show();
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            HotKey.HookStart();
            ani.Show();
        }
        

        private void tsmExit_Click(object sender, EventArgs e)
        {
            HotKey.HookEnd();
            System.Environment.Exit(0);
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            settingForm.Show();
        }

        private void tsmSite_Click(object sender, EventArgs e)
        {
            listForm.Show();
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            main.Show();
        }

        private void ntfIcon_DoubleClick(object sender, EventArgs e)
        {
            main.Show();
        }
        
    }
}
