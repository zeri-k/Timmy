using IBatisNet.DataMapper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

namespace Timmy
{
    public partial class MainForm : Form
    {
        public ChromeDriver driver;
        public ChromeDriverService ser = ChromeDriverService.CreateDefaultService();
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
        SettingForm sf = new SettingForm();

        [DllImport("user32.dll")]

        public static extern int ShowWindow(IntPtr hwnd, int cmdShow);
        public MainForm()
        {
            InitializeComponent();
        }

        private void ttsButton_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            string txt = txtView.Text;
            TTS tts = new TTS();
            tts.tts(txt);
            
            if (txt.Contains("켜"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (txt.Contains(list[i].siteName))
                    {
                        ss.SpeakAsync(list[i].siteName + "실행");
                        internet(list[i].url);

                    }
                }
            }
            else if (txt.Contains("꺼"))
            {
                if (txt.Contains("인터넷"))
                { 
                ss.SpeakAsync("인터넷 종료");
                driver.Quit();
                }
                for (int i = 0; i < list.Count; i++)
                {
                     if (txt.Contains(list[i].siteName))
                    {
                        ss.SpeakAsync(list[i].siteName + "종료");

                        close(list[i].url);
                    }
                }
            }
            else if (txt.Contains("이동"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (txt.Contains(list[i].siteName))
                    {
                        ss.SpeakAsync("인터넷 이동");
                        swit(list[i].url);
                    }
                }
            }
            if (txt.Contains("검색"))
            {
                ss.SpeakAsync(txt);
                if (driver.Url.Contains("naver"))
                    naversearch(txt.Replace("검색", ""));
                else if (driver.Url.Contains("google"))
                    googleSearch(txt.Replace("검색", ""));
            }
            if (txt.Contains("로그인"))
            {
                ss.SpeakAsync(txt);
                if (txt.Contains("구글"))
                    googlelogin();
                else
                {
                    MessageBox.Show("환경설정 확인");
                }
            }
            if (txt.Contains("메일확인"))
            {
                if (txt.Contains("구글"))
                {
                    googlemail();
                }
                else
                {
                    MessageBox.Show("나머지는개발중 ^^7");
                }
            }
            if (txt.Contains("새로고침"))
            {
                driver.Navigate().Refresh(); 
            }
            if (txt.Contains("앞으로"))
            {
                driver.Navigate().Forward();
            }
            if (txt.Contains("뒤로"))
            {
                driver.Navigate().Back();
            }
        }
        public void googlelogin()
        {
            try
            {
                driver.Url = ("https://www.google.com/");
                driver.FindElement(By.XPath("//*[@id='gb_70']")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("identifierId")).SendKeys((id)+ "capstone8797@gmail.com");
                Thread.Sleep(500);
                driver.FindElement(By.XPath("//*[@id='identifierNext']/content/span")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Name("password")).SendKeys("asdf8797!");
                Thread.Sleep(1500);
                driver.FindElement(By.XPath("//*[@id='passwordNext']/content/span")).Click();
            }
            catch(Exception)
            {
                MessageBox.Show("환경설정 확인");
            }
        }
        public void googlemail()
        {
            string a;
            driver.Url = ("https://mail.google.com/");
            Thread.Sleep(3000);
            if (driver.Url.Contains("https://www.google.com/intl/ko/gmail/about/"))  //로그인 안됐을시
            {
                googlelogin();
                driver.Url = ("https://mail.google.com/");
            }
            var list = driver.FindElements(By.ClassName("yW"));
            var cont = list.Count;
            resultbox.AppendText("총 "+cont+"개의 메일이 있습니다" + Environment.NewLine);
            for (int i =0; i<cont; i++) {
                var q = list[i];
                resultbox.AppendText(q.Text + Environment.NewLine);
            }
        }
        public void close(string url) // 탭 끄기
        {
            try
            { 
                for (int i = 0; i < driver.WindowHandles.Count();++i)
                {
                    if (driver.SwitchTo().Window(driver.WindowHandles.ElementAt(i)).Url.Contains(url))
                    {
                        driver.SwitchTo().Window(driver.WindowHandles.ElementAt(i));
                        driver.Close();
                    }
                }
             if(driver.WindowHandles.Count()!=0)
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
            }
            catch (Exception)
            {

            }
        }
        public void swit(string url) //탭 이동
        {
            try
            {
                for (int i = 0; i < driver.WindowHandles.Count(); i++)
                {
                    if (driver.SwitchTo().Window(driver.WindowHandles.ElementAt(i)).Url.Contains(url))
                    {
                        driver.SwitchTo().Window(driver.WindowHandles.ElementAt(i));
                        break;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
      
        public void internet(string url)
        {
            Console.WriteLine("new ChromeDriver");
            ser.HideCommandPromptWindow = true;
            try
            {
                Process[] pro = Process.GetProcessesByName("chrome");
                
            if (driver != null)
                driver.Quit();
            driver = new ChromeDriver(ser, new ChromeOptions());


            driver.Manage().Window.Maximize();
            driver.Url = ("https://www." + url + "/");
            txtView.Text = "";
                if (driver == null)
            {
                     driver = new ChromeDriver(ser, new ChromeOptions());
                    driver.Manage().Window.Maximize();
                    driver.Url = ("https://www." + url + "/");
            }
                else 
                {
                            driver.SwitchTo().Window(driver.WindowHandles.Last());
                            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                            driver.SwitchTo().Window(driver.WindowHandles.Last());
                          driver.Navigate().GoToUrl("https://www." + url + "/");
                        
                }
            }
            catch(Exception e)
            {
                driver = new ChromeDriver(ser, new ChromeOptions());
                driver.Manage().Window.Maximize();
                driver.Url = ("https://www." + url + "/");
            }
        }
        //구글 검색
        public void googleSearch(string searchword)
        {
            try
            {
                IWebElement q = driver.FindElement(By.Name("q"));
                q.Clear();
                q.SendKeys(searchword);
                q.Submit();
                var wt = driver.FindElement(By.XPath("//*[@id='rhs_block']/div/div[1]/div/div[1]/div[2]/div[2]/div/div[1]/div/div"));
                resultbox.Text = wt.Text;
                ss.SpeakAsync(resultbox.Text);
            }
            catch (Exception e)
            {
                driver.Url=("https://www.google.com");
            }

            if (searchword.Contains("날씨"))
            {
                IWebElement q = driver.FindElement(By.Name("q"));
                q.Clear();
                q.SendKeys(searchword);
                q.Submit();

                var wt = driver.FindElement(By.CssSelector(".vk_gy.vk_h"));
                resultbox.Text = wt.Text;
                ss.SpeakAsync(resultbox.Text);
            }
            txtView.Text = "";
        }

        // 네이버 검색
        public void naversearch(string searchword)
        {
            if (searchword.Contains("날씨"))
            {
                Thread.Sleep(1000);
                IWebElement q = driver.FindElement(By.CssSelector("[id$=query]"));
                q.SendKeys(searchword);
                driver.FindElement(By.Id("search_btn")).Click();
                var wt = driver.FindElement(By.ClassName("cast_txt"));
                resultbox.Text = wt.Text;
                ss.SpeakAsync(resultbox.Text);
            }
            else if (searchword.Contains("최신노래"))
            {
                IWebElement q = driver.FindElement(By.CssSelector("[id$=query]"));
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
                    resultbox.AppendText(i + "위  " + sing + "  -  " + song + Environment.NewLine);
                }
            }
            else
            {
                try
                {
                    IWebElement q = driver.FindElement(By.CssSelector("[id$=query]"));
                    q.Clear();
                    q.SendKeys(searchword);
                    q.Submit();

                }
                catch (Exception e)
                {
                    //MessageBox.Show("오류");
                   /* IWebElement q = driver.FindElement(By.Id("nx_query"));
                    q.Clear();
                    q.SendKeys(searchword);
                    q.Submit();*/
                }
            }
            txtView.Text = "";
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
            ss = new SpeechSynthesizer();
            
            STT.StreamingMicRecognizeAsync(5);
            ResultText(5);
                
        }

            async void ResultText(int time)
        {
            await Task.Delay(time * 1000);
            this.txtView.Text += STT.resultText + "\r\n";
        }
            
        private void txtView_TextChanged(object sender, EventArgs e)
        {
            if (txtView.Text != "")
            {
                Beep(1280, 50);
                Beep(1024, 50);
            }

            ss = new SpeechSynthesizer();
            string txt = txtView.Text;
            TTS tts = new TTS();
            tts.tts(txt);

            if (txt.Contains("켜"))
            {
                //새 탭으로 여는거 추가요망
                for (int i = 0; i < list.Count; i++)
                {
                    if (txt.Contains(list[i].siteName))
                    {
                        ss.SpeakAsync(list[i].siteName + "실행");
                        internet(list[i].url);
                        //이거 바꾸면 됨
                    }
                }
            } else if (txt.Contains("꺼"))
            {
                ss.SpeakAsync("인터넷 종료");
                driver.Quit();
            } else if (txt.Contains("이동"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (txt.Contains(list[i].siteName))
                    {
                        ss.SpeakAsync("인터넷 이동");
                        internet(list[i].url);
                    }
                }
            } else if (txt.Contains("검색"))
            {
                ss.SpeakAsync(txt);
                if (driver.Url.Contains("naver"))
                    naversearch(txt.Replace("검색", ""));
                else if (driver.Url.Contains("google"))
                    googleSearch(txt.Replace("검색", ""));
            } else if (txt.Contains("현재 페이지 등록"))
            {
                ss.SpeakAsync("무슨 이름으로 등록 할까요?");

                addSite(2);
            }
            else
            {
                txtView.Text = "";
            }
            

            async void addSite(int time)
            {
                await Task.Delay(time*1000);
                txtView.Text = "";
                btnSpeechStart_Click(sender, e);
                await Task.Delay(6 * 1000);
                ss.SpeakAsync(txtView.Text + "로 등록 되었습니다.");

                try
                {
                    Site site = new Site();

                    site.siteName = txtView.Text;
                    site.url = driver.Url;

                    Mapper.Instance().Insert("setSiteIns", site);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    txtView.Text = "";
                }
            }
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
