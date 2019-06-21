namespace Timmy.Forms
{
    partial class Animation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animation));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picturSeBox1 = new System.Windows.Forms.PictureBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturSeBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picturSeBox1
            // 
            this.picturSeBox1.BackColor = System.Drawing.Color.Transparent;
            this.picturSeBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturSeBox1.Image")));
            this.picturSeBox1.Location = new System.Drawing.Point(43, 216);
            this.picturSeBox1.Name = "picturSeBox1";
            this.picturSeBox1.Size = new System.Drawing.Size(207, 158);
            this.picturSeBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturSeBox1.TabIndex = 0;
            this.picturSeBox1.TabStop = false;
            // 
            // tbxResult
            // 
            this.tbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxResult.Location = new System.Drawing.Point(12, 48);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(278, 162);
            this.tbxResult.TabIndex = 4;
            this.tbxResult.Visible = false;
            this.tbxResult.Click += new System.EventHandler(this.tbxResult_Click);
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.picturSeBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Animation";
            this.Text = "Animation";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picturSeBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picturSeBox1;
        private System.Windows.Forms.TextBox tbxResult;
    }
}