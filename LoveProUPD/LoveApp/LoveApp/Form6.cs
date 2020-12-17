using System;
using System.Windows.Forms;
namespace LoveApp
{
    public partial class frmCapDoi : Form
    {
        public frmCapDoi()
        {
            InitializeComponent();
            Shows();           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Shows();
        }

        private void Shows()
        {
            try
            {
                lstNam.Items.Clear();
                lstNu.Items.Clear();
                string filePath = @"CapGhepDoi.txt";
                string filePathView = @"View.txt";
                string[] lines;
                string[] linesView;
                lines = System.IO.File.ReadAllLines(filePath);
                linesView = System.IO.File.ReadAllLines(filePathView);           
                int n, m = 0, p = 0;
                
                //Xác định vị trí mã ghép đôi của cặp vừa mới ghép đôi
                n = lines.Length - 3;

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
                    linesView = System.IO.File.ReadAllLines(filePathView);
                    
                    //Tìm trong file View thông tin của 2 đối tượng vừa ghép đôi hiển thị lần lượt trong lstbox Nam và lstbox Nữ
                    for (int j = m; j < m + 23; j++)
                    {
                        if(linesView[m+3] == "Giới tính: NAM")
                            lstNam.Items.Add(linesView[j]);
                        else
                            lstNu.Items.Add(linesView[j]);
                    }
                    for (int j = p; j < p + 23; j++)
                    {
                        if (linesView[p + 3] == "Giới tính: NỮ")
                            lstNu.Items.Add(linesView[j]);
                        else
                            lstNam.Items.Add(linesView[j]);
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Lỗi File: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }       
    }
}
