using System.Diagnostics;
using System.Speech.Synthesis;


namespace Timmy
{
    class TTS
    {
        public SpeechSynthesizer ss;
        public void tts(string txt)
        {
            if (txt.Contains("티미"))
            {
                ss.SpeakAsync("네 티미입니다");

            }
            Selenium sel = new Selenium();
            if (txt.Contains("네이버"))
            {
                sel.selenium();
            }
            //프로세서 
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
            ss = new SpeechSynthesizer();

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
