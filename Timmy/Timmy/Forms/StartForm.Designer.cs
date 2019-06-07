namespace Timmy.Forms
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(373, 359);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "시작하기";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(245, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 120);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timmy";
            // 
            // cms1
            // 
            this.cms1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmLogin,
            this.tsmSite,
            this.tsmExit});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(189, 100);
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(188, 24);
            this.tsmLogin.Text = "로그인 관리";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmSite
            // 
            this.tsmSite.Name = "tsmSite";
            this.tsmSite.Size = new System.Drawing.Size(188, 24);
            this.tsmSite.Text = "인터넷주소 목록";
            this.tsmSite.Click += new System.EventHandler(this.tsmSite_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(188, 24);
            this.tsmExit.Text = "종료";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // ntfIcon
            // 
            this.ntfIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfIcon.BalloonTipText = "티미트레이 입니다.";
            this.ntfIcon.BalloonTipTitle = "티미트레이";
            this.ntfIcon.ContextMenuStrip = this.cms1;
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = "Timmy";
            this.ntfIcon.Visible = true;
            this.ntfIcon.DoubleClick += new System.EventHandler(this.ntfIcon_DoubleClick);
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(188, 24);
            this.tsmOpen.Text = "열기";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartForm";
            this.Text = "시작";
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.NotifyIcon ntfIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmSite;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
    }
}