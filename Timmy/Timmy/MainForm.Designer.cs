namespace Timmy
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpeechStart = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.TextBox();
            this.ttsButton = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpeechStart
            // 
            this.btnSpeechStart.Location = new System.Drawing.Point(58, 46);
            this.btnSpeechStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpeechStart.Name = "btnSpeechStart";
            this.btnSpeechStart.Size = new System.Drawing.Size(125, 52);
            this.btnSpeechStart.TabIndex = 0;
            this.btnSpeechStart.Text = "음성 인식 시작";
            this.btnSpeechStart.UseVisualStyleBackColor = true;
            this.btnSpeechStart.Click += new System.EventHandler(this.btnSpeechStart_Click);
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(67, 149);
            this.txtView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(571, 213);
            this.txtView.TabIndex = 1;
            this.txtView.TextChanged += new System.EventHandler(this.txtView_TextChanged);
            // 
            // ttsButton
            // 
            this.ttsButton.Location = new System.Drawing.Point(210, 46);
            this.ttsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ttsButton.Name = "ttsButton";
            this.ttsButton.Size = new System.Drawing.Size(135, 52);
            this.ttsButton.TabIndex = 2;
            this.ttsButton.Text = "tts";
            this.ttsButton.UseVisualStyleBackColor = true;
            this.ttsButton.Click += new System.EventHandler(this.ttsButton_Click);
            // 
            // resultbox
            // 
            this.resultbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultbox.Location = new System.Drawing.Point(378, 12);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultbox.Size = new System.Drawing.Size(260, 114);
            this.resultbox.TabIndex = 3;
            this.resultbox.TextChanged += new System.EventHandler(this.resultbox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 460);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.ttsButton);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.btnSpeechStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeechStart;
        public System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button ttsButton;
        public System.Windows.Forms.TextBox resultbox;
    }
}

