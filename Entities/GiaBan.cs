using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.Entities
{
    class GiaBan
    {
        private string tenhang, mahang;
        private int giaban, gianhap;
        public GiaBan(string tenhang,string mahang,int giaban,int gianhap)
        {
            this.tenhang = tenhang;
            this.mahang = mahang;
            this.giaban = giaban;
            this.gianhap = gianhap;
        }
        override
            public string ToString()
        {
            return tenhang + "#" + mahang + "#" + giaban + "#" + gianhap;
        }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Mahang { get => mahang; set => mahang = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int Gianhap { get => gianhap; set => gianhap = value; }
    }
}
