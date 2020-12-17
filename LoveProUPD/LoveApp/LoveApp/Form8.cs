using System;
using System.Windows.Forms;
namespace LoveApp
{
    public partial class frmLichSu : Form
    {
        public frmLichSu()
        {
            InitializeComponent();
        }                

        private void lstLichSu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstThongTin.Items.Clear();
                lstThongTin1.Items.Clear();
                string filePath = @"CapGhepDoi.txt";
                string filePathView = @"View.txt";
                string[] lines;
                string[] linesView;
                lines = System.IO.File.ReadAllLines(filePath);
                linesView = System.IO.File.ReadAllLines(filePathView);
                lstThongTin.Items.Clear();
                int n = 0, m = 0, p = 0;
                
                //Xác định vị trí của mã ghép đôi được chọn
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == lstLichSu.SelectedItem.ToString())
                        n = i;
                }

                if (System.IO.File.Exists(filePathView))
                {
                    linesView = System.IO.File.ReadAllLines(filePathView);
                    for (int i = 0; i < linesView.Length; i++)
                    {
                        if (linesView[i] == lines[n + 1])
                            m = i;
                        if (linesView[i] == lines[n + 2])
                            p = i;
                    }
                    
                    //Hiển thị thông tin 2 đối tượng được ghép đôi ứng với mã được chọn lên 2 lstbox tương ứng
                    linesView = System.IO.File.ReadAllLines(filePathView);
                    for (int j = m; j < m + 23; j++)
                    {
                        lstThongTin.Items.Add(linesView[j]);
                    }
                    for (int j = p; j < p + 23; j++)
                    {
                        lstThongTin1.Items.Add(linesView[j]);
                    }
                }                
            }
            catch (Exception a)
            {
                MessageBox.Show("Lỗi File: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lstLichSu.Items.Clear();
                string filePath = @"CapGhepDoi.txt";
                string[] lines;
                if (System.IO.File.Exists(filePath))
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    for (int i = 0; i < lines.Length; i += 3)
                    {
                        
                        //Kiểm tra Mã ghép đôi theo thời gian
                        if (String.Format("{0:ddMMyy}", dtpThoiGian.Value) == lines[i].Substring(2, 6))
                        {
                            lstLichSu.Items.Add(lines[i]);
                         
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Lỗi tệp tin!" + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }       
    }
}
