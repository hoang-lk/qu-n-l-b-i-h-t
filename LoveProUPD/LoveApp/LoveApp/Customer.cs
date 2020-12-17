using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace LoveApp
{
    public class Customer
    {
        public string tenTep { get; set; }
        public string hoVaTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string tonGiao { get; set; }
        public string danToc { get; set; }
        public Boolean gioiTinh { get; set; }
        public int chieuCao { get; set; }
        public float canNang { get; set; }
        public string queQuan { get; set; }
        public string dienThoai { get; set; }
        public string ngheNghiep { get; set; }
        public string mail { get; set; }
        public string facebook { get; set; }
        public string diaChi { get; set; }

        public string TTHN { get; set; }
        public string DDTC { get; set; }
        public string UD { get; set; }
        public string ND { get; set; }
        public string QNTY { get; set; }
        public string HMLT { get; set; }
        public string NNT { get; set; }


        public Boolean daBong { get; set; }
        public Boolean hocVan { get; set; }
        public Boolean caHat { get; set; }
        public Boolean muaSam { get; set; }
        public Boolean docSach { get; set; }
        public Boolean hoiHoa { get; set; }
        public Boolean duLich { get; set; }
        public Boolean nhayMua { get; set; }
        public Boolean gym { get; set; }
        public Boolean boiLoi { get; set; }
        public Boolean chayBo { get; set; }
        public Boolean bongChuyen { get; set; }
        public override string ToString()
        {
            return this.hoVaTen;
        }
    }
}
