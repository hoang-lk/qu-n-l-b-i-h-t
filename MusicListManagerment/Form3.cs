using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace MusicListManagerment
{
    public partial class frmTheLoai : Form
    {
        public static bool CheckChanged = false;

        List<DataRow> myList = new List<DataRow>();
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool check = false;

            /*TheLoai t = new TheLoai();
            t.MaTL = txtMaTL.Text;
            t.TenTL = txtTenTL.Text;
*/
            if (txtMaTL.Text == "")
            {
                MessageBox.Show("Mã thể loại trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTenTL.Text == "")
            {
                MessageBox.Show("Tên thể loại trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView t2 = (DataRowView)lstTheLoaiBH.SelectedItem;
            if (txtMaTL.Text == t2.Row["MaTL"].ToString())
                    check = true;
            if (check == true)
            {
                MessageBox.Show("Mã thể loại tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenTL.Text.ToLower() == t2.Row["TenTL"].ToString().ToLower())
                check = true;
            if (check == true)
            {
                MessageBox.Show("Tên thể loại tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //frmThongTin.DSTheLoai.Add(t);

            KetNoiCSDL.ThayDoiDL("insert into TheLoai1 values ('" + txtMaTL.Text.Trim() + "','" + txtTenTL.Text.Trim() + "')");

            /*using (TextWriter sw = new StreamWriter(@"DSTL.txt", true))
            {
                foreach (TheLoai s in frmThongTin.DSTheLoai)
                {
                    sw.WriteLine(t);
                }
            }*/
            ShowTheLoai();
            XoaManHinh();
            CheckChanged = true;
        }
        void XoaManHinh()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtMaTL.Focus();
        }
        void ShowTheLoai()
        {
            //lstTheLoaiBH.Items.Clear();
            /* foreach (TheLoai t in frmThongTin.DSTheLoai)
             {
                 lstTheLoaiBH.Items.Add(t);    
             }        */
            lstTheLoaiBH.DisplayMember = "TenTL";
            lstTheLoaiBH.ValueMember = "MaTL";
            lstTheLoaiBH.DataSource = KetNoiCSDL.LayBang("select * from TheLoai1");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstTheLoaiBH.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView t = (DataRowView)lstTheLoaiBH.SelectedItem;
            DialogResult ret = MessageBox.Show(
                "Bạn muốn xóa [ " + t.Row["TenTL"] +"]?",
                "Hỏi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                CheckChanged = true;
                //frmThongTin.DSTheLoai.Remove(t);
                //lstTheLoaiBH.Items.Remove(t);
                KetNoiCSDL.ThayDoiDL("delete from TheLoai1 where TenTl = '"+txtTenTL.Text+"' ");
                KetNoiCSDL.ThayDoiDL("delete from BaiHat where TenTl = '" + txtTenTL.Text + "' ");
                ShowTheLoai();
                MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            XoaManHinh();

            /*if (lstTheLoaiBH.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TheLoai t = lstTheLoaiBH.SelectedItem as TheLoai;
            DialogResult ret = MessageBox.Show(
                "Bạn muốn xóa [ " + t.TenTL + "]?",
                "Hỏi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                CheckChanged = true;
                frmThongTin.DSTheLoai.Remove(t);
                lstTheLoaiBH.Items.Remove(t);
            }
            XoaManHinh();
*/
        }   

        private void btnThoat_Click(object sender, EventArgs e)
        {           
            if (CheckChanged == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void lstTheLoaiBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTheLoaiBH.SelectedIndex != -1)
            {
                DataRowView t = (DataRowView)lstTheLoaiBH.SelectedItem;
                txtMaTL.Text = t.Row["MaTL"].ToString();
                txtTenTL.Text = t.Row["TenTl"].ToString();
                /*TheLoai t = lstTheLoaiBH.SelectedItem as TheLoai;
                txtMaTL.Text = t.MaTL;
                txtTenTL.Text = t.TenTL;*/
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "")
            {
                lstTheLoaiBH.DisplayMember = "TenTL";
                lstTheLoaiBH.ValueMember = "MaTL";
                lstTheLoaiBH.DataSource = KetNoiCSDL.LayBang("select * from TheLoai1 where TenTL Like '%" + txtTimKiem.Text + "%'");
                if (lstTheLoaiBH.Items.Count == 0)
                {
                    MessageBox.Show("Thể loại không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTimKiem.Text = "";
                    txtTimKiem.Focus();
                    return;
                }

                /* int count = 0;
                 List<TheLoai> DanhSachTam = new List<TheLoai>();
                 foreach (TheLoai t1 in frmThongTin.DSTheLoai)
                 {
                     if (txtTimKiem.Text.ToLower() == t1.TenTL.ToLower())
                     {
                         DanhSachTam.Add(t1);
                         count++;
                     }
                 }
                 if (count == 0)
                 {
                     MessageBox.Show("Thể loại không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     lstTheLoaiBH.Items.Clear();
                     txtTimKiem.Focus();
                     return;
                 }
                 lstTheLoaiBH.Items.Clear();
                 foreach (TheLoai t in DanhSachTam)
                 {
                     lstTheLoaiBH.Items.Add(t);
                 }*/
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            /*string filePath = @"DSTL.txt";
            String[] lines; ;
            lstTheLoaiBH.Items.Clear();

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    lstTheLoaiBH.Items.Add(lines[i]);
                }
            }*/
            lstTheLoaiBH.DisplayMember = "TenTL";
            lstTheLoaiBH.ValueMember = "MaTL";
            lstTheLoaiBH.DataSource = KetNoiCSDL.LayBang("select * from TheLoai1");

            
            /*foreach (DataRow dr in KetNoiCSDL.LayBang("select * from TheLoai1").Rows)
                lstTheLoaiBH.Items.Add(dr);
            lstTheLoaiBH.Items.Clear();*/
            /*foreach (TheLoai t in frmThongTin.DSTheLoai)
            {
                lstTheLoaiBH.Items.Add(t);
            }*/

        }      
    }
}
