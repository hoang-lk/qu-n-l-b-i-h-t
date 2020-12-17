using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
namespace LoveApp
{
    public partial class frmDangKy : Form
    {       
        public bool checkchanged = false;
        public static List<Customer> DSThongTin = new List<Customer>();
        List<int> ma =new List<int>();
        public frmDangKy()
        {
            InitializeComponent();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Tạo mảng vector lưu Sở thích tương ứng mỗi đối tượng 
            int[]vecto = new int[12];
            if (txtTen.Text == "" || txtHo.Text == "" || txtChieuCao.Text == null 
                ||txtCanNang.Text == null
                || txtDanToc.Text == "" || txtTonGiao.Text == ""
                || txtQueQuan.Text == "" || txtDienThoai.Text == "" || txtNgheNghiep.Text == ""
                || txtMail.Text == "" || txtFacebook.Text == "" || txtDiaChi.Text == ""
                || (rdbNam.Checked == false && rdbNu.Checked == false) || cboTTHN.Text == "" || txtDDTC.Text == null
                || txtUD.Text == "" || txtND.Text == ""
                || txtQNTY.Text == "" || txtHMLT.Text == "" || txtNNT.Text == "" || (ckbDB.Checked == false &&
                ckbHV.Checked == false && ckbCH.Checked == false && ckbMS.Checked == false && ckbDS.Checked == false &&
                ckbHH.Checked == false && ckbDL.Checked == false && ckbNM.Checked == false && ckbG.Checked == false &&
                ckbBL.Checked == false && ckbCB.Checked == false && ckbBC.Checked == false))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin cần thiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
            else
            {
                try
                {
                    try
                    {
                        float.Parse(txtChieuCao.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin chiều cao không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        float.Parse(txtCanNang.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Thông tin cân nặng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        long.Parse(txtDienThoai.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (DateTime.Now.Year - dtpNgaySinh.Value.Year <18)
                    {
                        MessageBox.Show("Xin lỗi! Bạn chưa đủ tuổi đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (cboTTHN.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng xác nhận tình trạng hôn nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    // tạo mảng các dòng lưu giá trị nhập vào
                    string[] showlines = new string[23];
                    showlines[1] = "Họ và tên: " + txtHo.Text + " " + txtTen.Text;
                    showlines[2] = "Ngày sinh: " + dtpNgaySinh.Value + "";
                    if (rdbNam.Checked == true)
                        showlines[3] = "Giới tính: NAM";
                    else
                        showlines[3] = "Giới tính: NỮ";
                    showlines[4] = "Chiều cao: " + txtChieuCao.Text + " cm";
                    showlines[5] = "Cân nặng: " + txtCanNang.Text + " kg";
                    showlines[6] = "Dân tộc: " + txtDanToc.Text;
                    showlines[7] = "Tôn giáo: " + txtTonGiao.Text;
                    showlines[8] = "Quê quán: " + txtQueQuan.Text;
                    showlines[9] = "Điện thoại: " + txtDienThoai.Text;
                    showlines[10] = "Nghề nghiệp: " + txtNgheNghiep.Text;
                    showlines[11] = "Mail: " + txtMail.Text;
                    showlines[12] = "Facebook: " + txtFacebook.Text;
                    showlines[13] = "Địa chỉ: " + txtDiaChi.Text;                    
                    showlines[14] = "Tình trạng hôn nhân: " + cboTTHN.SelectedItem.ToString();        
                    showlines[15] = "Đặc điểm tính cách: " + txtDDTC.Text;
                    showlines[16] = "Ưu điểm: " + txtUD.Text;
                    showlines[17] = "Nhược điểm: " + txtND.Text;
                    showlines[18] = "Sở thích: ";                 
                    
                    //Kiểm tra Sở thích nhập vào ứng với mỗi đối tượng lưu vào phần tử mảng vecto
                    if (ckbDB.Checked == true)
                    {
                        vecto[0] = 1;
                        showlines[19] += "  Đá bóng";
                    }
                    if (ckbHV.Checked == true)
                    {
                        vecto[1] = 1;
                        showlines[19] += "  Học vấn";
                    }
                    if (ckbCH.Checked == true)
                    {
                        vecto[2] = 1;
                        showlines[19] += "  Ca hát";
                    }
                    if (ckbMS.Checked == true)
                    {
                        vecto[3] = 1;
                        showlines[19] += "  Mua sắm";
                    }
                    if (ckbDS.Checked == true)
                    {
                        vecto[4] = 1;
                        showlines[19] += "  Đọc sách";
                    }
                    if (ckbHH.Checked == true)
                    {
                        vecto[5] = 1;
                        showlines[19] += "  Hội họa";
                    }
                    if (ckbDL.Checked == true)
                    {
                        vecto[6] = 1;
                        showlines[19] += "  Du lịch";
                    }
                    if (ckbNM.Checked == true)
                    {
                        vecto[7] = 1;
                        showlines[19] += "  Nhảy múa";
                    }
                    if (ckbG.Checked == true)
                    {
                        vecto[8] = 1;
                        showlines[19] += "  Gym";
                    }
                    if (ckbBL.Checked == true)
                    {
                        vecto[9] = 1;
                        showlines[19] += "  Bơi lội";
                    }
                    if (ckbCB.Checked == true)
                    {
                        vecto[10] = 1;
                        showlines[19] += "  Chạy bộ";
                    }
                    if (ckbBC.Checked == true)
                    {
                        vecto[11] = 1;
                        showlines[19] += "  Bóng chuyền";
                    }
                    showlines[20] = "Quan niệm tình yêu: " + txtQNTY.Text;
                    showlines[21] = "Hình mẫu lý tưởng: "+ txtHMLT.Text;
                    showlines[22] = "Gu người nổi tiếng mong muốn là người yêu: " + txtNNT.Text;
                    
                    //Tạo mã tự động cho mỗi người tham gia khi đăng ký
                    showlines[0] = String.Format("{0:ddMMyyhhmmsstt}", DateTime.Now);                   
                    
                    //Tạo mảng lưu mã và Vecto Sở thích tương ứng mỗi Người tham gia
                    string[] lineST = new string[2];
                    foreach (int i in vecto)
                    {
                        lineST[1] += i;
                    }
                    lineST[0] = String.Format("{0:ddMMyyhhmmsstt}", DateTime.Now); 
                    
                    //Lưu vào thông tin theo 2 file tương ứng giới tính Nam và Nữ
                    if (rdbNam.Checked == true)
                    {
                        using (TextWriter sw = new StreamWriter(@"STNam.txt", true))
                        {
                            foreach (string s in lineST)
                            {
                                sw.WriteLine(s);
                            }
                        }
                    }
                    else
                    {
                        using (TextWriter sw = new StreamWriter(@"STNu.txt", true))
                        {
                            foreach (string s in lineST)
                            {
                                sw.WriteLine(s);
                            }
                        }
                    }
                   
                    //Lưu vào file ghi đè thông tin để xuất file trong form 2 thông tin người tham gia vừa mới lưu
                    string fileEPath = @"fileTTCNedit.txt";
                    System.IO.File.WriteAllLines(fileEPath, showlines);
                    
                    //Lưu vào tất cả danh sách thông tin người tham gia vào 1 file
                    using (TextWriter sw = new StreamWriter(@"View.txt", true))
                    {
                        foreach (string s in showlines)
                        {
                            sw.WriteLine(s);
                        }
                    }               
                    checkchanged = true;
                    DialogResult ret = MessageBox.Show("Chúc mừng bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                catch (Exception a)
                {
                    MessageBox.Show("Phát hiện lỗi dữ liệu nhập vào: "+ a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {

                }
            }
        }

        

        void ClearScreen()
        {
            txtHo.Text = "";
            txtTen.Text = "";
            rdbNam.Checked = true;
            txtChieuCao.Text = "";
            txtCanNang.Text = "";
            txtQueQuan.Text = "";
            txtDanToc.Text = "";
            txtTonGiao.Text = "";
            txtNgheNghiep.Text = "";
            txtDienThoai.Text = "";
            txtFacebook.Text = "";
            txtMail.Text = "";
            txtDiaChi.Text = "";
            cboTTHN.Text = "";
            txtDDTC.Text = "";
            txtUD.Text = "";
            txtND.Text = "";

            ckbDB.Checked = false;
            ckbHV.Checked = false;
            ckbCH.Checked = false;
            ckbMS.Checked = false;
            ckbDS.Checked = false;
            ckbHH.Checked = false;
            ckbDL.Checked = false;
            ckbNM.Checked = false;
            ckbG.Checked = false;
            ckbBL.Checked = false;
            ckbCB.Checked = false;
            ckbBC.Checked = false;

            txtQNTY.Text = "";
            txtHMLT.Text = "";
            txtNNT.Text = "";

            txtHo.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearScreen();
            checkchanged = false;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (checkchanged == true)
            {
                ClearScreen();
                frmThongTin frmTT = new frmThongTin();

                if (frmTT.ShowDialog() == DialogResult.OK)
                {
                    frmTT.frmDK = this;
                    frmTT.Show();
                }
                checkchanged = false;
            }
            else
            {
                MessageBox.Show("Bạn chưa lưu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
