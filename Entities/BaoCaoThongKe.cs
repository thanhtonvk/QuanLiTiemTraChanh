using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.Entities
{
    class BaoCaoThongKe
    {
        private string mahoadon, tenmathang;
        private int tongtien;
        public BaoCaoThongKe(string mahoadon,string tenmathang,int tongtien)
        {
            this.mahoadon = mahoadon;
            this.tenmathang = tenmathang;
            this.tongtien = tongtien;
        }
        override
            public string ToString()
        {
            return mahoadon + "#" + tenmathang + "#" + tongtien;
        }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Tenmathang { get => tenmathang; set => tenmathang = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
