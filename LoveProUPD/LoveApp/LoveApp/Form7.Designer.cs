namespace LoveApp
{
    partial class frmLoveApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoveApp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkTC = new System.Windows.Forms.LinkLabel();
            this.lnkDK = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.LightBlue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TÌM MỘT NỬA CỦA BẠN CÙNG CHÚNG TÔI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(0, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mọi thông tin chi tiết vui lòng liên hệ chúng tôi qua duyduonglee81@gmail.com. Hâ" +
    "n hạnh được phục vụ quý khách!\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lnkTC
            // 
            this.lnkTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkTC.AutoSize = true;
            this.lnkTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkTC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lnkTC.Location = new System.Drawing.Point(702, 96);
            this.lnkTC.Name = "lnkTC";
            this.lnkTC.Size = new System.Drawing.Size(203, 21);
            this.lnkTC.TabIndex = 2;
            this.lnkTC.TabStop = true;
            this.lnkTC.Text = "Go to ADMINISTRATOR";
            this.lnkTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkTC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkDK
            // 
            this.lnkDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDK.AutoSize = true;
            this.lnkDK.BackColor = System.Drawing.Color.White;
            this.lnkDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lnkDK.Location = new System.Drawing.Point(702, 53);
            this.lnkDK.Name = "lnkDK";
            this.lnkDK.Size = new System.Drawing.Size(243, 21);
            this.lnkDK.TabIndex = 3;
            this.lnkDK.TabStop = true;
            this.lnkDK.Text = "Go to ĐĂNG KÝ THÔNG TIN";
            this.lnkDK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLoveApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkTC);
            this.Controls.Add(this.lnkDK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.MinimizeBox = false;
            this.Name = "frmLoveApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Love Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkTC;
        private System.Windows.Forms.LinkLabel lnkDK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}