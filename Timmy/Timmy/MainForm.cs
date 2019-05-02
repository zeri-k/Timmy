using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Data.SQLite;

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
            
            DAO.connection();

            string[,] parser = new string[,] { { "네이버", "naver.com" }, { "다음", "daum.net" }, { "구글", "google.com" } };

            if (txt.Contains("켜"))
            {
              
                //새 탭으로 여는거 추가요망
                for (int i = 0; i < parser.GetLength(0); i++)
                {
                    if (txt.Contains(parser[i, 0]))
                    {
                        ss.SpeakAsync(parser[i,0] + "실행");
                        internet(parser[i, 1]);
                        
                            
                        //이거 바꾸면 됨
                    }
                }
            }
            else if (txt.Contains("꺼"))
            {
             
                    ss.SpeakAsync("인터넷 종료");
                    driver.Quit();
                
            }else if (txt.Contains("이동"))
            {
<<<<<<< HEAD
                for (int i = 0; i < parser.GetLength(0); i++)
                {
                    if (txt.Contains(parser[i, 0]))
                    {
                        ss.SpeakAsync("인터넷 이동");
                        internet(parser[i, 0]);

                    }
                }
=======
               // driver.SwitchTo().Window()
>>>>>>> origin/ui
            }

            if (txt.Contains("검색"))
            {
                ss.SpeakAsync(txt);
                naversearch(txt.Replace("검색", ""));
            }
            
        }


        public void resultbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        public void internet(string url)
        {
            ser.HideCommandPromptWindow = true;
            driver = new ChromeDriver(ser, new ChromeOptions());
            driver.Manage().Window.Maximize();
            driver.Url = ("https://www." + url);

        }

        // 주소입력
        /*
        public void adr(string url) 
        {
<<<<<<< HEAD
            driver.Url = ("https://www." + url );

=======
            driver.Url = ("https://www." + url + "/");
>>>>>>> stt
        }
        */
        // 검색어입력
        public void naversearch(string searchword)
        {
            if (searchword == "날씨")
            {
                Thread.Sleep(1000);
                IWebElement q = driver.FindElement(By.Id("query"));
                q.SendKeys(searchword);
                driver.FindElement(By.Id("search_btn")).Click();
                var wt = driver.FindElement(By.ClassName("cast_txt"));
                resultbox.Text = wt.Text;
                ss.SpeakAsync(resultbox.Text);
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
               
                    IWebElement q = driver.FindElement(By.Id("query"));
                    q.Clear();
                    q.SendKeys(searchword);
                    driver.FindElement(By.Id("search_btn")).Click();
                
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

