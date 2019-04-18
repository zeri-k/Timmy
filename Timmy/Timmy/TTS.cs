using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;


namespace Timmy
{
    class TTS
    {
        public SpeechSynthesizer ss;
        public void tts(string txt)  //텍스트를 음성으로 변환
        {
<<<<<<< HEAD
            ss = new SpeechSynthesizer();
            Selenium sel = new Selenium();
=======
            string a;
>>>>>>> 6c2871d0aa022d0bbf2e889f583452ac9bd6e9dc
            if (txt.Contains("티미"))
            {
                ss.SpeakAsync("네 티미입니다");
            }
<<<<<<< HEAD
          
            if (txt.Contains("네이버"))
            {
                ss.SpeakAsync("네이버 실행");
                sel.selenium();
                
=======
            Selenium sel = new Selenium();
            if (txt.Contains("인터넷"))
            {
                if (txt.Contains("네이버"))
                {
                    sel.internet("naver");
                    if (txt.Contains("노래순위"))
                    {
                        sel.navermusic10();
                    }
                }
                if (txt.Contains("다음"))
                {
                    sel.internet("daum");
                }
                if (txt.Contains("구글"))
                { 
                    sel.internet("google");
                    if(txt.Contains("로그인"))
                    {
                        sel.googlelogin();
                    }
                }
                if (txt.Contains("꺼"))
                {
                    sel.chromeexit();
                }
>>>>>>> 6c2871d0aa022d0bbf2e889f583452ac9bd6e9dc
            }
            //프로세서 on,off
            if (txt.Contains("엑셀"))
            {
                doProgram("excel", txt, "엑셀");
            }
            if (txt.Contains("메모장"))
            {
                doProgram("notepad", txt, "메모장");
            }
            if (txt.Contains("그림판"))
            {
                doProgram("mspaint", txt, "그림판");
            }
            if (txt.Contains("계산기"))
            {
                doProgram("calc", txt, "계산기");
            }
            //컴퓨터 제어
            if (txt.Contains("컴퓨터"))
            {
                if (txt.Contains("꺼"))
                {
                    ss.SpeakAsync("컴퓨터를 종료합니다");
                    Process.Start("shutdown.exe", "-s -t 03"); //3초뒤 종료
                }
                else if (txt.Contains("재부팅"))
                {
                    ss.SpeakAsync("컴퓨터를 재부팅합니다");
                    Process.Start("shutdown.exe", "-r -t 03");
                }
            }
            MainForm mainForm = new MainForm();
            mainForm.txtView.Text = "";
        }

        private void doProgram(string filename, string txt, string key) //프로세서 실행, 종료 (계산기,콘솔x 32bit??)
        {
           

            if (txt.Contains("켜")) // 실행
            {
                ss.SpeakAsync(key + "실행");
                Process.Start(filename);
            }
            else if (txt.Contains("꺼")) //종료
            {
                Process[] pro = Process.GetProcessesByName(filename);
                Process cu = Process.GetCurrentProcess();
                foreach (Process proc in pro)
                {

                    if (proc.Id != cu.Id)
                        ss.SpeakAsync(key + "종료");
                        proc.Kill();

                }

            }
        }

    }
}
