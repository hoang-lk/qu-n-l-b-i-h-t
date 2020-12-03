using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MusicListManagerment
{
    public class BaiHat
    {
        DataConnection dc;
        public string MaBH { get; set; }
        public string TenBH { get; set; }
        public string TacGia { get; set; }
        public string QuocGia { get; set; }
        public DateTime NamPhatHanh { get; set; }       
        public TheLoai Nhom { get; set; }
        public override string ToString()
        {
            return this.TenBH;
        }

        private class DataConnection
        {
        }
    }
}
