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
using IBatisNet.DataMapper;

namespace Timmy
{
    public partial class MainForm : Form
    {
        public SpeechSynthesizer ss;
        IList<Site> list = Mapper.Instance().QueryForList<Site>("SelectSite", null);
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int n, int m);
        // 도 = 256Hz
        // 레 = 도 * 9/8 = 288Hz
        // 미 = 레 * 10/9 = 320Hz
        // 파 = 미 * 16/15 = 341.3Hz
        // 솔 = 파 * 9/8 = 384Hz
        // 라 = 솔 * 10/9 = 426.6Hz
        // 시 = 라 * 9/8 = 480Hz
        // 도 = 시 * 16/15 = 512Hz (= 처음 도의 2배)
        // 2배 = 높은음, 1/2배 = 낮은음
        public string id, pw;

        SeleniumDriver sd = SeleniumDriver.Instance;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void ttsButton_Click(object sender, EventArgs e)
        {
            sd.textChange();
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
            if(STT.resultText != null)
                sd.setInput(STT.resultText + "\r\n");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        

        private void tsmExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
