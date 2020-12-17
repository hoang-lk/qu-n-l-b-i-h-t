using System.Windows.Forms;
namespace LoveApp
{
    public partial class frmThongTin : Form
    {
        public frmDangKy frmDK = new frmDangKy();
        public frmThongTin()
        {
            InitializeComponent();

            //Đọc file lưu thông tin người tham gia vừa mới nhập vào
            string filePath = @"fileTTCNedit.txt";
            string[] lines;
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    lsbTT.Items.Add(lines[i]);
                }
            }
        }    

        private void lnkTroLaiDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
