using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.Entities
{
    class NhanVien
    {
        private string manhanvien, tennhanvien, diachi, sdt;
        public NhanVien(string manhanvien,string tennhanvien,string diachi,string sdt)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        override
            public string ToString()
        {
            return manhanvien + "#" + tennhanvien + "#" + diachi + "#" + sdt;
        }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
