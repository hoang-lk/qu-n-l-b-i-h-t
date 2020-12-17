using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
namespace LoveApp
{
    public partial class frmHeThong : Form
    {
        List<string> maPH = new List<string>();
        List<string> maPHTTHN = new List<string>();
        public frmDangKy frmDK = new frmDangKy();
        public static List<Customer> DSHoanThanh = new List<Customer>();
        bool checkchanged = false;
        bool checkTimKiem = false;
        int checkTuoi = 0;
        public frmHeThong()
        {
            InitializeComponent();
            ShowFile();
        }

        void ShowFile()
        {
            try
            {
                string filePathNa = @"STNam.txt";
                string filePathNu = @"STNu.txt";
                string[] linesNa;
                string[] linesNu;
                if (System.IO.File.Exists(filePathNa))
                {
                    linesNa = System.IO.File.ReadAllLines(filePathNa);
                    for (int i = 0; i < linesNa.Length; i += 2)
                    {
                        cboTenTep.Items.Add(linesNa[i]);
                    }
                }
                if (System.IO.File.Exists(filePathNu))
                {
                    linesNu = System.IO.File.ReadAllLines(filePathNu);
                    for (int i = 0; i < linesNu.Length; i += 2)
                    {
                        cboTenTep.Items.Add(linesNu[i]);
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Lỗi tệp tin!" + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }             

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn xóa tệp [" + cboTenTep.SelectedItem.ToString() + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                
                // Xóa dòng file (trong file File.txt) có tên được chọn trên combobox
                string fileFPath = @"File.txt";
                string filePath = cboTenTep.SelectedItem.ToString();
                string[] lines;


                lines = System.IO.File.ReadAllLines(fileFPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == filePath)
                        File.Delete(lines[i]);
                }

                // Xóa file chứa nội dung thông tin customer
                System.IO.File.Delete(filePath);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTenTep.Items.Remove(cboTenTep.SelectedItem);
                frmDangKy.DSThongTin.Remove(ReadData(filePath));
            }
        }

        Customer ReadData(string filePath)
        {
            Customer information = new Customer();
            string[] lines;
            lines = System.IO.File.ReadAllLines(filePath);

            information.hoVaTen = lines[1];
            try
            {
                information.ngaySinh = DateTime.Parse(lines[3]);
            }
            catch (Exception a)
            {
                MessageBox.Show("Lỗi định dạng Ngày tháng năm: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            information.chieuCao = int.Parse(lines[8]);
            information.canNang = float.Parse(lines[10]);
            information.danToc = lines[12];
            information.tonGiao = lines[14];
            information.queQuan = lines[16];
            information.dienThoai = lines[18];
            information.ngheNghiep = lines[20];
            information.mail = lines[22];
            information.facebook = lines[24];
            information.diaChi = lines[26];
            information.TTHN = lines[28];
            information.DDTC = lines[30];
            information.UD = lines[32];
            information.ND = lines[34];
            information.QNTY = lines[49];
            information.HMLT = lines[51];
            information.NNT = lines[53];

            if (lines[5] == "NAM")
                information.gioiTinh = true;
            if (lines[6] == "NỮ")
                information.gioiTinh = false;
            if (lines[36] == "Đá bóng")
                information.daBong = true;
            else
                information.daBong = false;
            if (lines[37] == "Học vấn")
                information.hocVan = true;
            else
                information.hocVan = false;
            if (lines[38] == "Ca hát")
                information.caHat = true;
            else
                information.caHat = false;
            if (lines[39] == "Mua sắm")
                information.muaSam = true;
            else
                information.muaSam = false;
            if (lines[40] == "Đọc sách")
                information.docSach = true;
            else
                information.docSach = false;
            if (lines[41] == "Hội họa")
                information.hoiHoa = true;
            else
                information.hoiHoa = false;
            if (lines[42] == "Du lịch")
                information.duLich = true;
            else
                information.duLich = false;
            if (lines[43] == "Nhảy múa")
                information.nhayMua = true;
            else
                information.nhayMua = false;
            if (lines[44] == "Gym")
                information.gym = true;
            else
                information.gym = false;
            if (lines[45] == "Bơi lội")
                information.boiLoi = true;
            else
                information.boiLoi = false;
            if (lines[46] == "Chạy bộ")
                information.chayBo = true;
            else
                information.chayBo = false;
            if (lines[47] == "Bóng chuyền")
                information.bongChuyen = true;
            else
                information.bongChuyen = false;
            lines[56] = information.tenTep;
            return information;

        }

        //Hàm trả về vị trí của phần tử lớn nhất trong mảng
        int maxIndex(List<int> count)
        {
            int max = count[0];
            int maxIndex = 0;
            for (int i = 0; i < count.Count; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    maxIndex = i;
                }                    
            }
            return maxIndex;
        }

        //Hàm trả về khoảng cách tuổi
        public Int32 KCTuoi(DateTime d, DateTime e)
        {
            return Math.Abs(d.Year - e.Year);
        }

        //Hàm chuyển từ số nhị phân sang số thập phân
        long Nhi_Thap(long n)
        {

            double dec = 0, i = 0, d;
            while (n != 0)
            {
                d = n % 10;
                dec = dec + d * Math.Pow(2, i); 
                n = n / 10;
                i++;
            }
            long a = (long)dec;
            return a;
        }

        //Hàm chuyển từ số thập phân sang nhị phân
        long Thap_Nhi( long n)
        {
            long i, j, binno = 0;
            
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }
            return binno;
        }
        

        private void btnGhepDoi_Click(object sender, EventArgs e)
        {
            maPH.Clear();
            maPHTTHN.Clear();
            checkTuoi = 0;
            lstDanhSachPhuHop.Items.Clear();
            string filePathNa = @"STNam.txt";
            string filePathNu = @"STNu.txt";
            string[] linesNa;
            string[] linesNu;
            List<long> result = new List<long>();
            List<int> count = new List<int>();
            if(cboTenTep.SelectedIndex == -1 || cboTenTep.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng ghép đôi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            // Nam
            linesNa = System.IO.File.ReadAllLines(filePathNa);           
            string str = "";
            int check = 0;
            for (int i = 0; i < linesNa.Length; i+=2)
            {
                
                //Kiểm tra đối tượng được chọn là mã của người tham gia Nam hay Nữ
                if (linesNa[i] == cboTenTep.SelectedItem.ToString())
                {
                    str = linesNa[i + 1]; //Lưu dòng chứa vecto Sở thích của người tham gia có mã được chọn
                    check = 1; //Đối tượng là mã của người tham gia Nam
                }    
                                 
            }
            if(check == 1)
            {
                
                //Đọc file Nữ
                linesNu = System.IO.File.ReadAllLines(filePathNu);
                
                //Tạo mảng result lưu kết quả xor của từng người tham gia Nữ với người tham gia Nam được chọn
                for (int j = 0; j < linesNu.Length; j++)
                    result.Add(0);
                
                //Duyệt các vecto sở thích của tất cả người tham gia Nữ
                for (int j = 1; j < linesNu.Length; j += 2)
                {
                    
                    //xor sở thích của đối tượng được chọn với từng sở thích của Nữ trong file Nữ
                    long v = Nhi_Thap(long.Parse(linesNu[j])) ^ Nhi_Thap(long.Parse(str));
                    
                    //Chuyển v thành nhị phân
                    result[j] = Thap_Nhi(v);
                }
                
                //Tạo mảng count đếm độ phù hợp tương ứng với từng kết quả xor
                for (int i = 0; i < result.Count; i++)
                {
                    if (i % 2 == 1) count.Add(12);
                    else count.Add(0);

                } 
                
                //Đếm từng kết quả xor phù hợp nhất để lưu vào từng phần tử của mảng count    
                for (int i = 1; i < result.Count; i += 2)
                {
                    for (int j = 0; j < result[i].ToString().ToCharArray().Length; j++)
                    {
                        if (result[i].ToString().ToCharArray()[j] == 1)
                        count[i]--;
                    }
                }

                //Tạo List temp lưu các vị trí tại giá trị count lớn nhất
                List<int> temp = new List<int>();
                for (int i = 0; i < count.Count; i++)
                {
                    if (maxIndex(count) == 0) continue;
                    temp.Add(maxIndex(count));//Thêm từng vị trí max trong count vào temp
                    count[maxIndex(count)] = 0;
                }
                for(int i = temp.Count-1;i>=0;i--)
                {
                    lstDanhSachPhuHop.Items.Add(linesNu[(temp[i] - 1)]);
                    maPH.Add(linesNu[(temp[i] - 1)]);
                }
            }
            else
            {
                List<long> resultNu = new List<long>();
                List<int> countNu = new List<int>();
                //Nu
                linesNu = System.IO.File.ReadAllLines(filePathNu);
                string strNu = "";
                for (int i = 0; i < linesNu.Length; i += 2)
                {
                    if (linesNu[i] == cboTenTep.SelectedItem.ToString())
                        strNu = linesNu[i + 1];
                }
                linesNa = System.IO.File.ReadAllLines(filePathNa);
                for (int j = 0; j < linesNa.Length; j++)
                    resultNu.Add(0);
                for (int j = 1; j < linesNa.Length; j += 2)
                {
                    long v = Nhi_Thap(long.Parse(linesNa[j])) ^ Nhi_Thap(long.Parse(strNu));
                    resultNu[j] = Thap_Nhi(v);
                }
                for (int i = 0; i < resultNu.Count; i++)
                {
                    if(i%2 == 1)
                        countNu.Add(12);
                    else
                        countNu.Add(0);
                }    
                   
                for (int i = 1; i < resultNu.Count; i += 2)
                {
                    for (int j = 0; j < resultNu[i].ToString().ToCharArray().Length; j++)
                    {
                        if (resultNu[i].ToString().ToCharArray()[j] == 1)
                        count[i]--;
                    }
                }
                List<int> tempNu = new List<int>();
                for (int i = 0; i < countNu.Count; i++)
                {
                    if (maxIndex(countNu) == 0) continue;
                    tempNu.Add(maxIndex(countNu));
                    countNu[maxIndex(countNu)] = 0;
                }
                
                for (int i = tempNu.Count - 1; i >= 0;i--)
                {
                    lstDanhSachPhuHop.Items.Add(linesNa[(tempNu[i] - 1)]);
                    maPH.Add(linesNa[(tempNu[i] - 1)]); //Lưu vào list phù hợp
                }
            }
            checkchanged = true;
        }

        private void cboTenTep_SelectedIndexChanged_1(object sender, EventArgs e)
        {           
            try
            {
                rdbTTHN.Checked = false;
                rdbTuoi.Checked = false;
                lstDanhSachPhuHop.Items.Clear();
                lstThongTin1.Items.Clear();
                string filePath = @"View.txt";
                string[] lines;
                lstThongTin.Items.Clear();
                int n = 0 ;
                if (System.IO.File.Exists(filePath))
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i] == cboTenTep.SelectedItem.ToString())
                            n = i;
                    }
                    lines = System.IO.File.ReadAllLines(filePath);
                    for (int j = n; j < n + 23; j++)
                    {
                        lstThongTin.Items.Add(lines[j]);
                    }
                    txtTen.Text = lines[n + 1].Substring(11).ToUpper();
                }
                
            }
            catch (Exception a)
            {
                MessageBox.Show("Lỗi File: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {            
            string filePath = @"View.txt";
            string[] lines;
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    lstThongTin.Items.Add(lines[i]);
                }
            }
        }

        private void btnChonGhepDoi_Click(object sender, EventArgs e)
        {
            if (cboTenTep.SelectedIndex == -1 || cboTenTep.Text =="")
            {
                MessageBox.Show("Bạn cần file người muốn ghép đôi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void lstDanhSachPhuHop_SelectedIndexChanged(object sender, EventArgs e)
        {          
            try
            {
                string filePath = @"View.txt";
                string[] lines;
                lstThongTin1.Items.Clear();
                int n = 0;
                if (System.IO.File.Exists(filePath))
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i] == lstDanhSachPhuHop.SelectedItem.ToString())
                            n = i;
                        else if (lines[i].Length > 13 && lines[i].Substring(11).ToUpper() == lstDanhSachPhuHop.SelectedItem.ToString())
                            n = i - 1;
                    }
                    lines = System.IO.File.ReadAllLines(filePath);
                    for (int j = n; j < n + 23; j++)
                    {
                        lstThongTin1.Items.Add(lines[j]);
                    }
                }

            }
            catch (Exception a)
            {               
                MessageBox.Show("Lỗi File: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCapDoi frmCD = new frmCapDoi();
            frmCD.ShowDialog();            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            cboTenTep.Text = "";
            lstDanhSachPhuHop.Items.Clear();
            lstThongTin.Items.Clear();
            lstThongTin1.Items.Clear();
            txtTen.Text = "";
            maPH.Clear();
            maPHTTHN.Clear();
            rdbTTHN.Checked = false;
            rdbTuoi.Checked = false;
            checkTuoi = 0;
            checkTimKiem = false;
        }
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (checkchanged == false)
            {
                MessageBox.Show("Bạn chưa tìm đối tượng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstThongTin1.Items.Clear();
            string filePath = @"View.txt";
            string[] lines;
            lines = System.IO.File.ReadAllLines(filePath);
            int n = 0;
            if (System.IO.File.Exists(filePath))
            {

                for (int i = 0; i < lines.Length; i++)
                {

                    //Xác định vị trí trong file của đối tượng được chọn 
                    if (lines[i] == cboTenTep.SelectedItem.ToString())
                        n = i;
                }
            }
            if (rdbTTHN.Checked == true)
            {
                checkTuoi = 1;
                try
                {
                    //maPHTTHN.Clear();
                    lstDanhSachPhuHop.Items.Clear();
                    foreach (string str in maPH)
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {

                            //Kiểm tra từng đối tượng phù hợp
                            if (str == lines[i])
                            {
                                if (lines[n + 14] == lines[i + 14])//Lọc theo tình trạng hôn nhân phù hợp giữa đối tượng được chọn và từng đối tượng tương ứng trong danh sách phù hợp
                                {
                                    lstDanhSachPhuHop.Items.Add(lines[i]);
                                    maPHTTHN.Add(lines[i]);
                                }
                            }

                        }
                    }


                }
                catch (Exception a)
                {
                    MessageBox.Show("Lỗi File: " + a.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (rdbTuoi.Checked == true)
            {
                if (checkTuoi == 1)
                {
                    maPH.Clear();
                    foreach (string str2 in maPHTTHN)
                        maPH.Add(str2);

                }
                //Tạo list count gồm tất cả các giá trị -1
                List<int> count = new List<int>();
                for (int i = 0; i < lines.Length; i++)
                {
                    count.Add(-1);
                }
                lstDanhSachPhuHop.Items.Clear();
                foreach (string str in maPH)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (str == lines[i])
                        {
                            count[i] = Math.Abs(DateTime.Parse(lines[n + 2].Substring(11)).Year - DateTime.Parse(lines[i + 2].Substring(11)).Year);
                            //if (count[i] == 0)
                            //lstDanhSachPhuHop.Items.Add(lines[i]);
                        }
                    }
                }
                List<int> temp = new List<int>();
                for (int i = 0; i < count.Count; i++)
                {

                    if (maxIndex(count) == 0) continue;
                    temp.Add(maxIndex(count));
                    count[maxIndex(count)] = -1;
                }
                int c = temp.Count - 1;
                for (int i = c; i >= 0; i--)
                {
                    lstDanhSachPhuHop.Items.Add(lines[temp[i]]);
                }
            }
        }

        private void btnGhep_Click(object sender, EventArgs e)
        {
            if (lstDanhSachPhuHop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn đối tượng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkTimKiem == true)
            {
                MessageBox.Show("Thực hiện ghép đôi không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*DialogResult ret = MessageBox.Show("Bạn chắc chắn muốn ghép đôi [" + cboTenTep.SelectedItem.ToString() + "]\nvới [" + lstDanhSachPhuHop.SelectedItem.ToString() + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);*/
            DialogResult ret = MessageBox.Show("Bạn chắc chắn muốn ghép đôi [" + lstThongTin.Items[1].ToString().Substring(11).ToUpper() + "]\nvới [" + lstThongTin1.Items[1].ToString().Substring(11).ToUpper() + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {

                //Tạo các dòng để lưu vào file mã Ghép đôi và cặp ghép đôi
                string[] lines = new string[3];
                lines[0] = String.Format("GD{0:ddMMyyhhmmsstt}", DateTime.Now);
                lines[1] = cboTenTep.SelectedItem.ToString();
                lines[2] = lstDanhSachPhuHop.SelectedItem.ToString();
                using (TextWriter sw = new StreamWriter(@"CapGhepDoi.txt", true))
                {
                    foreach (string s in lines)
                    {
                        sw.WriteLine(s);
                    }
                }
                MessageBox.Show("Ghép đôi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Xóa 2 đối tượng vừa được xác nhận ghép đôi
                string filePathNa = @"STNam.txt";
                string filePathNu = @"STNu.txt";
                string[] linesNa;
                string[] linesNu;
                linesNa = System.IO.File.ReadAllLines(filePathNa);
                linesNu = System.IO.File.ReadAllLines(filePathNu);
                int k = 0, k1 = 0; ;
                var fileNa = new List<string>(System.IO.File.ReadAllLines("STNam.txt"));
                var fileNu = new List<string>(System.IO.File.ReadAllLines("STNu.txt"));

                //Xác định vị trị trong file của từng đối tượng
                for (int i = 0; i < linesNa.Length; i++)
                {
                    if (linesNa[i] == cboTenTep.SelectedItem.ToString())
                    {
                        k = i;
                    }
                    if (linesNa[i] == lstDanhSachPhuHop.SelectedItem.ToString())
                    {
                        k = i;
                    }
                }
                for (int i = 0; i < linesNu.Length; i++)
                {
                    if (linesNu[i] == cboTenTep.SelectedItem.ToString())
                    {
                        k1 = i;
                    }
                    if (linesNu[i] == lstDanhSachPhuHop.SelectedItem.ToString())
                    {
                        k1 = i;
                    }
                }

                //Xóa mã và vecto Sở thích của đối tượng tương ứng trong file Nam
                fileNa.RemoveAt(k);
                fileNa.RemoveAt(k);
                File.WriteAllLines("STNam.txt", fileNa.ToArray());

                //Xóa mã và vecto Sở thích của đối tượng tương ứng trong file Nữ
                fileNu.RemoveAt(k1);
                fileNu.RemoveAt(k1);
                File.WriteAllLines("STNu.txt", fileNu.ToArray());
            }
            lstThongTin.Items.Clear();
            lstThongTin1.Items.Clear();
            lstDanhSachPhuHop.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmLichSu frmLS= new frmLichSu();
            frmLS.ShowDialog();
        }       

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            checkTimKiem = true;
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            string[] lines;
            lstThongTin.Items.Clear();
            lstThongTin1.Items.Clear();
            lstDanhSachPhuHop.Items.Clear();
            lines = System.IO.File.ReadAllLines("View.txt");
            int[] n = new int[lines.Length];
            for (int i =1;i<lines.Length;i+=23)
            {
                
                //Lưu vào mảng n các vị trí của đối tượng cần tìm kiếm nếu có trong file 
                if(lines[i].ToLower().Contains(txtTen.Text.ToLower()) == true)
                {
                    n[i] = i;                    
                }               
            }
            int count = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                if(n[i] != 0)
                {
                    //lstDanhSachPhuHop.Items.Add(lines[n[i]-1]);
                    lstDanhSachPhuHop.Items.Add(lines[n[i]].Substring(11).ToUpper());
                    count++;
                }                    
            }
            if (count == 0)      
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstDanhSachPhuHop.Items.Clear();
            }    
        }
    }
}
