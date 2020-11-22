using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.Entities
{
    class MatHang
    {
        private string mamathang, tenmathang;
        private int giaban, soluongcu, soluongmoi;
        public MatHang(string mamathang,string tenmathang,int giaban,int soluongcu,int soluongmoi)
        {
            this.mamathang = mamathang;
            this.tenmathang = tenmathang;
            this.giaban = giaban;
            this.soluongcu = soluongcu;
            this.soluongmoi = soluongmoi;
        }
        override
            public string ToString()
        {
            return mamathang + "#" + tenmathang + "#" + giaban + "#" + soluongcu + "#" + soluongmoi;
        }
        public string Mamathang { get => mamathang; set => mamathang = value; }
        public string Tenmathang { get => tenmathang; set => tenmathang = value; }
        public int Giaban { get => giaban; set => giaban = value; }
        public int Soluongcu { get => soluongcu; set => soluongcu = value; }
        public int Soluongmoi { get => soluongmoi; set => soluongmoi = value; }
    }
}
