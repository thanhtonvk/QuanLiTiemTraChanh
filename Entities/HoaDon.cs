using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.Entities
{
    class HoaDon
    {
        private string mahoadon, tenhoadon, tennhanvienban, mahang, tenhang;
        private int soluong, giaban;

        public HoaDon(string mahoadon, string tenhoadon, string tennhanvienban, string mahang, string tenhang, int soluong, int giaban)
        {
            this.mahoadon = mahoadon;
            this.tenhoadon = tenhoadon;
            this.tennhanvienban = tennhanvienban;
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.giaban = giaban;
        }

        override
            public string ToString()
        {
            return mahoadon + "#" + tenhoadon + "#" + tennhanvienban + "#" + mahang + "#" + tenhang + "#" + soluong + "#" + giaban;
        }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Tenhoadon { get => tenhoadon; set => tenhoadon = value; }
        public string Tennhanvienban { get => tennhanvienban; set => tennhanvienban = value; }
        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Giaban { get => giaban; set => giaban = value; }
    }
}
