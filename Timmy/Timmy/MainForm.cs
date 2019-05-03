using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;


namespace Timmy
{
    public partial class MainForm : Form
    {
        Selenium sel = new Selenium();
        public IWebDriver driver;
        public ChromeDriverService ser = ChromeDriverService.CreateDefaultService();
        public SpeechSynthesizer ss;


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSpeechStart_Click(object sender, EventArgs e)
        {
            STT.StreamingMicRecognizeAsync(5);
            this.txtView.Text += STT.resultText + "\r\n";
        }
        public void txtView_TextChanged(object sender, EventArgs e)
        {

        }
        public void ttsButton_Click(object sender, EventArgs e)
        {

            ss = new SpeechSynthesizer();
            string txt = txtView.Text;

            TTS tts = new TTS();
            tts.tts(txt);
            if (txt == ("인터넷"))
            {
                internet();
            }
            if (txt==("네이버"))
            {
                adr("naver.com");
            }
            if(txt == ("구글"))
            {
                adr("google.com");
            }
            if (txt==("인터넷꺼"))
            {
            }
            if (txt.Contains("검색"))
            {
                naversearch(txt.Replace("검색", ""));
            }
        }
        public void resultbox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        public void internet()
        {

            ser.HideCommandPromptWindow = true;
            driver = new ChromeDriver(ser, new ChromeOptions());
            driver.Manage().Window.Maximize();  

        }
        public void adr(string url) // 주소입력
        {
            driver.Url = ("https://www." + url + "/");

        }
        public void naversearch(string searchword) // 검색어입력
        {
            if (searchword == "날씨")
            {
                try
                {
                    Thread.Sleep(1000);
                    IWebElement q = driver.FindElement(By.Id("query"));
                    q.SendKeys(searchword);
                    driver.FindElement(By.Id("search_btn")).Click();
                    var wt = driver.FindElement(By.ClassName("cast_txt"));
                    resultbox.Text = wt.Text;
                }
                catch(Exception)
                {
                    Thread.Sleep(1000);
                    IWebElement q = driver.FindElement(By.Id("nx_query"));
                    q.Clear();
                    q.SendKeys(searchword);
                    driver.FindElement(By.ClassName("bt_search")).Click();
                    var wt = driver.FindElement(By.ClassName("cast_txt"));
                    resultbox.Text = wt.Text;
                }
            }
            else if(searchword =="최신노래")
            {
                    IWebElement q = driver.FindElement(By.Id("query"));
                    q.SendKeys(searchword);                        
                    driver.FindElement(By.Id("search_btn")).Click();
                    Thread.Sleep(3000);
                    var rank = driver.FindElement(By.ClassName("list_top_music"));
                    string song;
                    string sing;
                    for (int i = 1; i <= 10; i++)
                    {
                        var ranksong = rank.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[2]/ol/li[" + i + "]/div/div[1]/div[2]/div[1]/a")); 
                        var ranksinger = rank.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[2]/ol/li[" + i + "]/div/div[1]/div[2]/div[2]/a[1]"));

                    song = ranksong.Text;
                        sing = ranksinger.Text;
                        resultbox.AppendText(i + "위  " + sing + "  -  "+song + Environment.NewLine);
                    }
            }
            else
            {
                try { 
                IWebElement q = driver.FindElement(By.Id("query"));
                q.SendKeys(searchword);                       
                driver.FindElement(By.Id("search_btn")).Click();
                }catch(Exception)
                {
                    IWebElement q = driver.FindElement(By.Id("nx_query"));
                    q.Clear();
                    q.SendKeys(searchword);
                    driver.FindElement(By.ClassName("bt_search")).Click();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void 로그인관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SettingForm setform = new SettingForm();
            setform.StartPosition = FormStartPosition.Manual;
            setform.Location = new Point(380, 220);

            setform.Show();

        }

        private void 인터넷주소목록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           InternetListForm listForm = new InternetListForm();
            listForm.StartPosition = FormStartPosition.Manual;
            listForm.Location = new Point(380, 220);

            listForm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm form = new helpForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(500, 220);

            form.ShowDialog();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(500, 220);

            form.ShowDialog();
        }
    }
}

