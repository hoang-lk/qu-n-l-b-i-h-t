using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace MusicListManagerment
{
    public partial class frmThongTin : Form
    {
        public static List<TheLoai> DSTheLoai = new List<TheLoai>();
        List<BaiHat> DSBaiHat = new List<BaiHat>();

        public frmThongTin()
        {
            InitializeComponent();
            //ShowBaiHat();
            ShowTheLoai();           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDSTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoai frmTP = new frmTheLoai();
            frmTheLoai.CheckChanged = false;
            if (frmTP.ShowDialog() == DialogResult.OK)
            {
                ShowTheLoai();
                XoaManHinh();
            }
            
        }
        private void ShowTheLoai()
        {
            /* cboTheLoai.Items.Clear();
             foreach (TheLoai t in DSTheLoai)
             {
                 cboTheLoai.Items.Add(t);
             }     */

            cboTheLoai.DisplayMember = "TenTL";
            cboTheLoai.ValueMember = "MaTL";
            cboTheLoai.DataSource = KetNoiCSDL.LayBang("select * from TheLoai1");
        }
        void ShowBaiHat()
        {
            /*lstDanhSachBH.Items.Clear();
            foreach (BaiHat m in DSBaiHat)
            {
                lstDanhSachBH.Items.Add(m);
            }*/

            lstDanhSachBH.DisplayMember = "TenBH";
            lstDanhSachBH.ValueMember = "MaBH";
            lstDanhSachBH.DataSource = KetNoiCSDL.LayBang("select * from BaiHat");
        }
        void XoaManHinh()
        {
            cboTheLoai.Text = "";
            txtMaBH.Text = "";
            txtTenBH.Text = "";
            txtTacGia.Text = "";
            txtQuocGia.Text = "";
            txtDuongDan.Text = "";
            txtMaBH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool check = false;

            if (cboTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Thể loại không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaBH.Text == "" || txtTenBH.Text == "" || txtTacGia.Text == "" || txtQuocGia.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*TheLoai t = cboTheLoai.SelectedItem as TheLoai;
            BaiHat m = new BaiHat();
            m.MaBH = txtMaBH.Text;
            m.TenBH = txtTenBH.Text;
            m.TacGia = txtTacGia.Text;
            m.QuocGia = txtQuocGia.Text;
            m.NamPhatHanh = dtpNPH.Value;*/

            DataRowView m = (DataRowView)lstDanhSachBH.SelectedItem;
          
            if (txtMaBH.Text == m.Row["MaBH"].ToString())
                    check = true;
            if (check == true)
            {
                DialogResult ret = MessageBox.Show("Mã bài hát tồn tại!\nBạn có muốn cập nhật bài hát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(ret == DialogResult.Yes)
                {              
                    KetNoiCSDL.ThayDoiDL("update BaiHat set TenTL ='" + cboTheLoai.GetItemText(cboTheLoai.SelectedItem).Trim() + "', TenBH = '" + txtTenBH.Text.Trim() + "', TacGia = '" + txtTacGia.Text.Trim() + "', QuocGia = '" + txtQuocGia.Text.Trim() + "', NamPhatHanh = '" + dtpNPH.Value.ToString("MM/dd/yyyy").Trim() + "', LinkBH = '" + txtDuongDan.Text.Trim() + "' where MaBH = '" + txtMaBH.Text.Trim() + "'");                   
                    ShowBaiHat();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                XoaManHinh();
                return;
            }
            else
            {
                //t.addBH(m);
                //DSBaiHat.Add(m);                

                KetNoiCSDL.ThayDoiDL("insert into BaiHat( MaBH, TenBH, TenTL, TacGia, QuocGia, NamPhatHanh, LinkBH) values ('" + txtMaBH.Text.Trim() + "','" + txtTenBH.Text.Trim() + "' ,'" + cboTheLoai.GetItemText(cboTheLoai.SelectedItem).Trim() + "','" + txtTacGia.Text.Trim() + "','" + txtQuocGia.Text.Trim() + "','" + dtpNPH.Value.ToString("MM/dd/yyyy").Trim() + "','" + txtDuongDan.Text.Trim() + "')");
                ShowBaiHat();
                XoaManHinh();
            }

            /*int i = 0;
            bool check = false;

            if (cboTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Thể loại không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaBH.Text == "" || txtTenBH.Text == "" || txtTacGia.Text == "" || txtQuocGia.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TheLoai t = cboTheLoai.SelectedItem as TheLoai;
            BaiHat m = new BaiHat();
            m.MaBH = txtMaBH.Text;
            m.TenBH = txtTenBH.Text;
            m.TacGia = txtTacGia.Text;
            m.QuocGia = txtQuocGia.Text;
            m.NamPhatHanh = dtpNPH.Value;

            foreach (BaiHat m1 in DSBaiHat)
            {
                if (m.MaBH == m1.MaBH)
                    check = true;
            }
            if (check == true)
            {
                MessageBox.Show("Mã bài hát tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                t.addBH(m);
                DSBaiHat.Add(m);
                DataRowView cb = (DataRowView)cboTheLoai.SelectedItem;
                KetNoiCSDL.ThayDoiDL("insert into BaiHat values ('" + txtMaBH.Text.Trim() + "','" + txtTenBH.Text.Trim() + "'),'" + cb + "','" + txtTacGia.Text.Trim() + "','" + txtQuocGia.Text.Trim() + "','" + dtpNPH.Value + "'");

                ShowBaiHat();
                XoaManHinh();
            }*/

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSachBH.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn bài hát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRowView m = (DataRowView)lstDanhSachBH.SelectedItem;
            DialogResult ret = MessageBox.Show(
                "Bạn muốn xóa [" + m.Row["TenTL"].ToString() + "]?",
                "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                //DSBaiHat.Remove(m);
                KetNoiCSDL.ThayDoiDL("delete from BaiHat where TenBH = '" + txtTenBH.Text+ "' and MaBH = '" + txtMaBH.Text + "'");
                ShowBaiHat();
                MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            XoaManHinh();

            /*if (lstDanhSachBH.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn bài hát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BaiHat m = lstDanhSachBH.SelectedItem as BaiHat;
            DialogResult ret = MessageBox.Show(
                "Bạn muốn xóa [" + m.TenBH + "]?",
                "Hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                DSBaiHat.Remove(m);
                ShowBaiHat();
            }
            XoaManHinh();*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
               "Bạn muốn thoát?",
               "Hỏi",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                frmDangNhap frmDN = new frmDangNhap();
                this.Visible = false;
                if (frmDN.ShowDialog() == DialogResult.OK)
                {
                    frmThongTin frmTT = new frmThongTin();
                    frmTT.ShowDialog();
                }
            }
        }

        private void lstDanhSachBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhSachBH.SelectedIndex == -1)
            {
                return;
            }

            DataRowView m = (DataRowView)lstDanhSachBH.SelectedItem;
            cboTheLoai.SelectedItem = m;            
            cboTheLoai.Text = m.Row["TenTL"].ToString() ;
            txtMaBH.Text = m.Row["MaBH"].ToString();
            txtTenBH.Text = m.Row["TenBH"].ToString();
            txtTacGia.Text = m.Row["TacGia"].ToString();
            txtQuocGia.Text = m.Row["QuocGia"].ToString();
            dtpNPH.Text = m.Row["NamPhatHanh"].ToString();
            txtDuongDan.Text = m.Row["LinkBH"].ToString();
            /*BaiHat m = lstDanhSachBH.SelectedItem as BaiHat;
            cboTheLoai.SelectedItem = m;
            cboTheLoai.Text = m.Nhom.TenTL;
            txtMaBH.Text = m.MaBH;
            txtTenBH.Text = m.TenBH;
            txtTacGia.Text = m.TacGia;
            txtQuocGia.Text = m.QuocGia;
            dtpNPH.Value = m.NamPhatHanh;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XoaManHinh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                lstDanhSachBH.DisplayMember = "TenBH";
                lstDanhSachBH.ValueMember = "MaBH";
                lstDanhSachBH.DataSource = KetNoiCSDL.LayBang("select * from BaiHat where TenBH Like '%" + txtTimKiem.Text + "%'");
                if (lstDanhSachBH.Items.Count == 0)
                {
                    MessageBox.Show("Bài hát không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTimKiem.Text = "";
                    txtTimKiem.Focus();
                    return;
                }

                /*int count = 0;
                List<BaiHat> DanhSachTam = new List<BaiHat>();
                foreach (BaiHat m1 in DSBaiHat)
                {
                    if (txtTimKiem.Text.ToLower() == m1.TenBH.ToLower())
                    {
                        DanhSachTam.Add(m1);
                        count++;
                    }                  
                }
                if(count == 0)
                {
                    MessageBox.Show("Bài hát không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstDanhSachBH.Items.Clear();
                    txtTimKiem.Focus();
                    return;
                }       
                lstDanhSachBH.Items.Clear();
                foreach (BaiHat m in DanhSachTam)
                {
                        lstDanhSachBH.Items.Add(m);
                }*/
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*lstDanhSachBH.Items.Clear();
            foreach (BaiHat m in DSBaiHat)
            {
                lstDanhSachBH.Items.Add(m);
            }*/

            /*string filePath = @"DSBH.txt";
            string[] lines;
            lstDanhSachBH.Items.Clear();
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    lstDanhSachBH.Items.Add(lines[i]);
                }
            }*/
            lstDanhSachBH.DisplayMember = "TenBH";
            lstDanhSachBH.ValueMember = "MaBH";
            lstDanhSachBH.DataSource = KetNoiCSDL.LayBang("select * from BaiHat");           
            
        }
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
      
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //KetNoiCSDL.LayBang("select * from BaiHat where LinkBH ='" + txtDuongDan.Text + "'");
            if (lstDanhSachBH.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn bài hát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //DataRowView m = (DataRowView)lstDanhSachBH.SelectedItem;
                string filePath = txtDuongDan.Text + ".mp3";
                if (System.IO.File.Exists(filePath))
                {
                    wplayer.URL = filePath;
                    wplayer.controls.play();
                }
                else
                {
                    wplayer.controls.pause();
                    MessageBox.Show("Đường dẫn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                  
                    return;
                }
            }         
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (wplayer.status == "Paused")
                wplayer.controls.play();
            else
                wplayer.controls.pause(); 
            
        }
    }
}
