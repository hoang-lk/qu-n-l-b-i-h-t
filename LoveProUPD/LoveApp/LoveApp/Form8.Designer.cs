namespace LoveApp
{
    partial class frmLichSu
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLichSu = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstThongTin = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstThongTin1 = new System.Windows.Forms.ListBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1350, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH SỬ GHÉP ĐÔI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLichSu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 586);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã ghép đôi:";
            // 
            // lstLichSu
            // 
            this.lstLichSu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLichSu.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lstLichSu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstLichSu.FormattingEnabled = true;
            this.lstLichSu.ItemHeight = 22;
            this.lstLichSu.Location = new System.Drawing.Point(3, 22);
            this.lstLichSu.Name = "lstLichSu";
            this.lstLichSu.Size = new System.Drawing.Size(245, 561);
            this.lstLichSu.TabIndex = 0;
            this.lstLichSu.SelectedIndexChanged += new System.EventHandler(this.lstLichSu_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstThongTin);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(269, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 621);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết:";
            // 
            // lstThongTin
            // 
            this.lstThongTin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstThongTin.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lstThongTin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstThongTin.FormattingEnabled = true;
            this.lstThongTin.ItemHeight = 22;
            this.lstThongTin.Location = new System.Drawing.Point(3, 25);
            this.lstThongTin.Name = "lstThongTin";
            this.lstThongTin.Size = new System.Drawing.Size(513, 593);
            this.lstThongTin.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstThongTin1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Location = new System.Drawing.Point(794, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 618);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // lstThongTin1
            // 
            this.lstThongTin1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lstThongTin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstThongTin1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lstThongTin1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstThongTin1.FormattingEnabled = true;
            this.lstThongTin1.ItemHeight = 22;
            this.lstThongTin1.Location = new System.Drawing.Point(3, 25);
            this.lstThongTin1.Name = "lstThongTin1";
            this.lstThongTin1.Size = new System.Drawing.Size(538, 590);
            this.lstThongTin1.TabIndex = 0;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpThoiGian.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpThoiGian.Location = new System.Drawing.Point(15, 59);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(245, 32);
            this.dtpThoiGian.TabIndex = 4;
            this.dtpThoiGian.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử ghép đôi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLichSu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstThongTin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstThongTin1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
    }
}