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
            this.SuspendLayout();
            // 
            // btnSpeechStart
            // 
            this.btnSpeechStart.Location = new System.Drawing.Point(66, 58);
            this.btnSpeechStart.Name = "btnSpeechStart";
            this.btnSpeechStart.Size = new System.Drawing.Size(143, 65);
            this.btnSpeechStart.TabIndex = 0;
            this.btnSpeechStart.Text = "음성 인식 시작";
            this.btnSpeechStart.UseVisualStyleBackColor = true;
            this.btnSpeechStart.Click += new System.EventHandler(this.btnSpeechStart_Click);
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(77, 148);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(652, 265);
            this.txtView.TabIndex = 1;
            this.txtView.TextChanged += new System.EventHandler(this.txtView_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.btnSpeechStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeechStart;
        public System.Windows.Forms.TextBox txtView;
    }
}

