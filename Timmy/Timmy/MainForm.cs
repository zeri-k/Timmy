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

namespace Timmy
{
    public partial class MainForm : Form
    {
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

<<<<<<< HEAD
        private void MainForm_Load(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
        }

        private void ttsButton_Click(object sender, EventArgs e)
        {
            string txt = txtView.Text;


            if (txt.Contains("티미"))
            {
                ss.SpeakAsync("네 티미입니다");

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
            txtView.Text = "";

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
=======
        private void ttsButton_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            string txt = txtView.Text;

            TTS tts = new TTS();
            tts.tts(txt);
        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // se = new SpeechRecognitionEngine();
            /*
             String[] commands = { "티미", "계산기", "그림판", "메모장" };
             Choices choices = new Choices(commands);
             GrammarBuilder gb = new GrammarBuilder(choices);
             Grammar gram = new Grammar(gb);

             se.SetInputToDefaultAudioDevice();
             se.RecognizeAsync(RecognizeMode.Multiple);
             se.SpeechRecognized += se_SpeechRecognized;
             */

        }
        /*
        private void se_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //throw new NotImplementedException();
            String human = e.Result.Text;
            String computer = "";
   

        }
        */

>>>>>>> 95d9203a5a3a56bf71e50ceeffb5dddaa369264f
    }
}

