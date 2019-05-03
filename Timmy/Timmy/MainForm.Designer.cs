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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSpeechStart = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.TextBox();
            this.ttsButton = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인터넷주소목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.txtView.Location = new System.Drawing.Point(24, 121);
            this.txtView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(335, 154);
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
            this.resultbox.Location = new System.Drawing.Point(382, 46);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultbox.Size = new System.Drawing.Size(306, 229);
            this.resultbox.TabIndex = 3;
            this.resultbox.TextChanged += new System.EventHandler(this.resultbox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인관리ToolStripMenuItem,
            this.인터넷주소목록ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 로그인관리ToolStripMenuItem
            // 
            this.로그인관리ToolStripMenuItem.Name = "로그인관리ToolStripMenuItem";
            this.로그인관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.로그인관리ToolStripMenuItem.Text = "로그인관리";
            this.로그인관리ToolStripMenuItem.Click += new System.EventHandler(this.로그인관리ToolStripMenuItem_Click);
            // 
            // 인터넷주소목록ToolStripMenuItem
            // 
            this.인터넷주소목록ToolStripMenuItem.Name = "인터넷주소목록ToolStripMenuItem";
            this.인터넷주소목록ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.인터넷주소목록ToolStripMenuItem.Text = "인터넷주소 목록";
            this.인터넷주소목록ToolStripMenuItem.Click += new System.EventHandler(this.인터넷주소목록ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Timmy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeechStart;
        public System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button ttsButton;
        public System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인터넷주소목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
    }
}

