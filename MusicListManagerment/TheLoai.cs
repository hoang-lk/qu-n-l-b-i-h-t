using System;
using System.Collections.Generic;
using System.Text;

namespace MusicListManagerment
{  
    public class TheLoai
    {
        private Dictionary<string, BaiHat> DSBaiHat = new Dictionary<string, BaiHat>();
        public string MaTL { get; set; }
        public string TenTL{ get; set; }
        public void addBH(BaiHat m)
        {
            if (this.DSBaiHat.ContainsKey(m.MaBH) == false)
            {
                this.DSBaiHat.Add(m.MaBH, m);
                m.Nhom = this;
            }
        }
        public void delBH(BaiHat m)
        {
            if (this.DSBaiHat.ContainsKey(m.MaBH) == true)
            {
                this.DSBaiHat.Remove(m.MaBH, out m);               
            }
        }
        public Dictionary<string, BaiHat> BaiHat
        {
            get { return this.DSBaiHat; }
            set { this.DSBaiHat = value; }
        }
        public override string ToString()
        {
            return this.TenTL;
        }
    }
}
