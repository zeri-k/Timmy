using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using IBatisNet.DataMapper;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timmy.Forms;

namespace Timmy.ClassFile
{
    class Parser
    {
        private static Parser parser;
        private Parser()
        {
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();
        }
        public delegate void dgtSetBox(string result);
        private string siteName;
        private string setSite = "";
        public SpeechSynthesizer ss = new SpeechSynthesizer();
        IList<Site> list = Mapper.Instance().QueryForList<Site>("SelectSite", null);

        SeleniumDriver sd = SeleniumDriver.Instance;

        public static Parser Instance
        {
            get
            {
                if (parser == null)
                {
                    parser = new Parser();
                }
                return parser;
            }
        }

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

        public static string input = "";


        public void setInput(string intxt)
        {
            input += intxt;
            Console.WriteLine(input + "setText");
        }

        private void startInternet(string txt)
        {
            if (txt.Contains("인터넷"))
            {
                ss.SpeakAsync("인터넷 실행");
                sd.internet("google.com");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (txt.Contains(list[i].siteName))
                    {
                        ss.SpeakAsync(list[i].siteName + "실행");
                        sd.internet(list[i].url);
                        break;
                    }
                    else if (i == list.Count - 1)
                    {
                        ss.SpeakAsync("등록되지 않은 사이트 입니다. 메인 페이지로 실행합니다.");
                        sd.internet("google.com");
                    }
                }
            }
        }

        private void search(string txt)
        {
            ss.SpeakAsync(txt);

            string[] result = txt.Split(new string[] { "검색" }, StringSplitOptions.None);
            for (int i = 0; i < result.Length; i++)
            {
                txt = result[0];
            }

            if (txt.Contains("에서 "))
            {
                result = txt.Split(new string[] { "에서 " }, StringSplitOptions.None);
                move(result[0]);
                for (int i = 0; i < result.Length; i++)
                {
                    txt = result[1];
                }
            }

            if (sd.driver.Url.Contains("naver"))
            {
                sd.naversearch(txt);
                input = "";
            }
            else if (sd.driver.Url.Contains("google"))
            {
                sd.googleSearch(txt);
                input = "";
            }
            else if (sd.driver.Url.Contains("daum"))
            {
                sd.daumSearch(txt);
                input = "";
            }
            else
            {
                ss.SpeakAsync("지원하지 않는 페이지 입니다.");
            }
        }

        private void move(string txt)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (txt.Contains(list[i].siteName))
                {
                    sd.swit(list[i].url);
                    break;
                }
                else if (i == list.Count - 1)
                {
                    ss.SpeakAsync("등록되지 않은 사이트 입니다.");
                }
            }
        }

        public void textChange()
        {
            if (input != "")
            {
                Beep(1280, 50);
                Beep(1024, 50);
            }

            string txt = input;
            TTS tts = new TTS();
            tts.tts(txt);

            if (txt.Equals("티미야"))
            {
                ss.SpeakAsync("네, 말씀 하세요");
            }

            if (txt.Contains("Google"))
            {
                txt = txt.Replace("Google", "구글");
            }
            else if (txt.Contains("알려 줘"))
            {
                txt = txt.Replace("알려 줘", "검색");
            }
            else if (txt.Contains("찾아 줘"))
            {
                txt = txt.Replace("찾아 줘", "검색");
            }

            if (txt.Contains("켜") || txt.Contains("실행") || txt.Contains("열어 줘"))
            {
                startInternet(txt);
            }
            else if (txt.Contains("꺼") || txt.Contains("종료"))
            {
                if(sd.driver != null)
                {
                    if (txt.Contains("인터넷"))
                    {
                        ss.SpeakAsync("인터넷 종료");
                        sd.driver.Quit();
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (txt.Contains(list[i].siteName))
                        {
                            ss.SpeakAsync(list[i].siteName + "종료");
                            sd.close(list[i].url);
                            break;
                        }
                    }
                }
                else
                {
                    ss.SpeakAsync("인터넷이 이미 꺼져있습니다");
                }
            }
            else if (txt.Contains("이동"))
            {
                if (sd.driver != null)
                {
                    move(txt);
                }
                else
                {
                    ss.SpeakAsync("인터넷이 꺼져있습니다");
                }
            }
            else if (txt.Contains("검색"))
            {
                if (sd.driver == null)
                {
                    startInternet(txt);
                    search(txt);
                }
                else
                {
                    search(txt);
                }
            }
            else if (txt.Contains("로그인"))
            {
                if (sd.driver != null)
                {
                    if (txt.Contains("구글") || txt.Contains("Google"))
                    {
                        siteName = "google";
                        IList<Login> listLogin = Mapper.Instance().QueryForList<Login>("SelectSiteLogin", siteName);
                        sd.googlelogin(listLogin[0].id, listLogin[0].pw);
                        ss.SpeakAsync(txt);
                    }
                    else if (txt.Contains("다음"))
                    {
                        siteName = "daum";
                        IList<Login> listLogin = Mapper.Instance().QueryForList<Login>("SelectSiteLogin", siteName);
                        sd.daumlogin(listLogin[0].id, listLogin[0].pw);
                        ss.SpeakAsync(txt);
                    }
                    else
                    {
                        ss.SpeakAsync("아이디와 패스워드를 등록해 주세요");
                    }
                }
                else
                {
                    ss.SpeakAsync("인터넷이 꺼져있습니다");
                }
            }
            else if (txt.Contains("메일"))
            {
                if (sd.driver != null)
                {
                    if (txt.Contains("구글"))
                    {
                        sd.googlemail();
                        ss.SpeakAsync(txt);
                    }
                    else if (txt.Contains("다음"))
                    {
                        sd.daummail();
                        ss.SpeakAsync(txt);
                    }
                }
                else
                {
                    ss.SpeakAsync("인터넷이 꺼져있습니다");
                }
            }
            else if (txt.Equals("새로고침"))
            {
                if (sd.driver != null)
                {
                    sd.driver.Navigate().Refresh();
                }
                else
                {
                    ss.SpeakAsync("인터넷이 꺼져있습니다");
                }
            }
            else if (txt.Equals("앞으로 가기"))
            {
                if (sd.driver != null)
                {
                    sd.driver.Navigate().Forward();
                }
                else
                {
                    ss.SpeakAsync("인터넷이 꺼져있습니다");
                }
            }
            else if (txt.Equals("뒤로 가기"))
            {
                if (sd.driver != null)
                {
                    sd.driver.Navigate().Back();
                }
                else
                {
                    ss.SpeakAsync("인터넷이 꺼져있습니다");
                }
            }
            else if (txt.Contains("현재 페이지 등록"))
            {
                if (sd.driver != null)
                {
                    ss.SpeakAsync("무슨 이름으로 등록 할까요?");

                    addSite(3);
                }
                else
                {
                    ss.SpeakAsync("인터넷이 꺼져있습니다");
                }
            }
            else
            {
                ss.SpeakAsync("무슨 말인지 잘 모르겠네요");
                input = "";
            }

            void ResultText(int time)
            {
                if (STT.resultText != null)
                    setSite = STT.resultText + "\r\n";
            }

            async void addSite(int time)
            {
                try
                {
                    Console.WriteLine("페이지 등록 음성 인식 실행");
                    try
                    {
                        await STT.StreamingMicRecognizeAsync(5);
                        ResultText(5);
                        input = "";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                        MessageBox.Show("인터넷이 연결 되어 있지 않습니다.\n인터넷 연결 후 다시 시도 해 주세요");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("인터넷이 연결 되어 있지 않습니다.\n인터넷 연결 후 다시 시도 해 주세요");
                }

                try
                {
                    string[] result = setSite.Split(new string[] { "www." }, StringSplitOptions.None);
                    for (int i = 0; i < result.Length; i++)
                    {
                        setSite = result[1];
                    }

                    Site site = new Site();

                    site.siteName = setSite;
                    site.url = sd.driver.Url;

                    Mapper.Instance().Insert("setSiteIns", site);

                    ss.SpeakAsync(setSite + "로 등록 되었습니다.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    ss.SpeakAsync("등록에 실패 했습니다.");
                }
                finally
                {
                    setSite = "";
                    input = "";
                }

            }
            input = "";
        }


        static void Run()
        {
            while (true)
            {
                if (!input.Equals(""))
                {
                    parser.textChange();
                }
            }
        }
    }
}
