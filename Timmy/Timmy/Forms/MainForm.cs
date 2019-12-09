using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        
        Parser ps = Parser.Instance;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void ttsButton_Click(object sender, EventArgs e)
        {
            ps.textChange();
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

        private void btnSpeechStart_Click(object sender, EventArgs e)
        {
            speechStart();
        }

        public async void speechStart()
        {
            try{
                await STT.StreamingMicRecognizeAsync(5);
                ResultText(5);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("인터넷이 연결 되어 있지 않습니다.\n인터넷 연결 후 다시 시도 해 주세요");
            }
            
        }

        void ResultText(int time)
        {
            if(STT.resultText != null)
                ps.setInput(STT.resultText + "\r\n");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void resultbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            HotKey.HookEnd();
            System.Environment.Exit(0);
        }
    }
}
