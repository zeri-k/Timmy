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
            this.resultbox = new System.Windows.Forms.TextBox();
            this.ttsButton = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.TextBox();
            this.btnSpeechStart = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSite = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultbox
            // 
            this.resultbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultbox.Location = new System.Drawing.Point(378, 59);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultbox.Size = new System.Drawing.Size(301, 165);
            this.resultbox.TabIndex = 9;
            // 
            // ttsButton
            // 
            this.ttsButton.Location = new System.Drawing.Point(206, 59);
            this.ttsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ttsButton.Name = "ttsButton";
            this.ttsButton.Size = new System.Drawing.Size(135, 52);
            this.ttsButton.TabIndex = 8;
            this.ttsButton.Text = "tts";
            this.ttsButton.UseVisualStyleBackColor = true;
            this.ttsButton.Click += new System.EventHandler(this.ttsButton_Click);
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(19, 134);
            this.txtView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(335, 154);
            this.txtView.TabIndex = 7;
            // 
            // btnSpeechStart
            // 
            this.btnSpeechStart.Location = new System.Drawing.Point(53, 59);
            this.btnSpeechStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpeechStart.Name = "btnSpeechStart";
            this.btnSpeechStart.Size = new System.Drawing.Size(125, 52);
            this.btnSpeechStart.TabIndex = 6;
            this.btnSpeechStart.Text = "음성 인식 시작";
            this.btnSpeechStart.UseVisualStyleBackColor = true;
            this.btnSpeechStart.Click += new System.EventHandler(this.btnSpeechStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.tsmSite,
            this.환경설정ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(180, 22);
            this.tsmLogin.Text = "로그인관리";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmSite
            // 
            this.tsmSite.Name = "tsmSite";
            this.tsmSite.Size = new System.Drawing.Size(180, 22);
            this.tsmSite.Text = "인터넷주소 목록";
            this.tsmSite.Click += new System.EventHandler(this.tsmSite_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmHelp,
            this.tsmInfo});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(146, 22);
            this.tsmHelp.Text = "help";
            this.tsmHelp.Click += new System.EventHandler(this.tsmHelp_Click);
            // 
            // tsmInfo
            // 
            this.tsmInfo.Name = "tsmInfo";
            this.tsmInfo.Size = new System.Drawing.Size(146, 22);
            this.tsmInfo.Text = "프로그램정보";
            this.tsmInfo.Click += new System.EventHandler(this.tsmInfo_Click);
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.환경설정ToolStripMenuItem.Text = "환경설정";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 327);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.ttsButton);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.btnSpeechStart);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Button ttsButton;
        public System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button btnSpeechStart;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmSite;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmInfo;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
    }
}

