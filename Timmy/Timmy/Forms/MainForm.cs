using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using Timmy.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Timmy.ClassFile;

namespace Timmy
{
    public partial class MainForm : Form
    {
        public SpeechSynthesizer ss;
        SeleniumDriver sd = SeleniumDriver.Instance;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void ttsButton_Click(object sender, EventArgs e)
        {
            sd.ttsButton();
        }

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SetLoginForm settingForm = new SetLoginForm();
            settingForm.Show();

        }

        private void tsmSite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SetSiteForm listForm = new SetSiteForm();
            listForm.Show();
        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void tsmInfo_Click(object sender, EventArgs e)
        {
            InformationForm infoForm = new InformationForm();
            infoForm.Show();
        }

        public void btnSpeechStart_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();

            STT.StreamingMicRecognizeAsync(5);
            ResultText(5);
        }

        async void ResultText(int time)
        {
            await Task.Delay(time * 1000);
            sd.setInput(STT.resultText + "\r\n");
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm setForm = new SettingForm();
            setForm.Show();
            this.Visible = false;
        }
    }
}
