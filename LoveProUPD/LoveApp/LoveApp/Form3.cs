using System;
using System.Windows.Forms;
namespace LoveApp
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            ShowTKMK();
        }       
        
        void ShowTKMK()
        {
            if (ckbLuu.Checked == true)
            {
                txtTaiKhoan.Text = "admin";
                txtMatKhau.Text = "12345678";
            }          
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "12345678")
            {
                frmHeThong frmHT = new frmHeThong();                
                frmHT.ShowDialog();
                this.Close();                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
