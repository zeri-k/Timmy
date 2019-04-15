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
        private void ttsButton_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            string txt = txtView.Text;

            TTS tts = new TTS();
            tts.tts(txt);
        }
        public  void resultbox_TextChanged(object sender, EventArgs e)
        {
        }
        public void Re(String a)
        {
            resultbox.Text = a;
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
    }
}

