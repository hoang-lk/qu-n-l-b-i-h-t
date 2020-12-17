using System;
using System.Windows.Forms;
namespace LoveApp
{
    public partial class frmLoveApp : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public frmLoveApp()
        {
            InitializeComponent();
            
            wplayer.URL = @"TaLaCuaNhau-DongNhiOngCaoThang-4113753.mp3";
            wplayer.controls.play();
        }       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();
            if (frmDN.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frmDky = new frmDangKy();
            if (frmDky.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (wplayer.status == "Paused")
                wplayer.controls.play();
            else
                wplayer.controls.pause();
        }
    }
}
