using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLiTiemTraChanh.Entities;
namespace QuanLiTiemTraChanh.BLL
{
    class NhanVien_BLL
    {
        public static void NhapTT(ArrayList list)
        {
            Console.WriteLine("Nhập mã nhân viên");
            string manv = Nhap.NhapString();
            Console.WriteLine("Nhập tên nhân viên");
            string tenv = Nhap.NhapString();
            Console.WriteLine("Nhập địa chỉ");
            string diachi = Nhap.NhapString();
            Console.WriteLine("Nhập SĐT");
            string sdt = Nhap.NhapString();
            list.Add(new NhanVien(manv,tenv,diachi,sdt));
        }
        public static void Hien(NhanVien NhanVien)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", NhanVien.Manhanvien, NhanVien.Tennhanvien, NhanVien.Diachi, NhanVien.Sdt);
        }
        public static void HienAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "Mã nhân viên", "Tên nhân viên", "Địa chỉ", "Số điện thoại");
            foreach (NhanVien NhanVien in arrayList)
            {
                Hien(NhanVien);
            }
        }
        public static NhanVien Find(ArrayList arrayList)
        {
            NhanVien kq = null;
            Console.WriteLine("Nhập mã hóa đơn:");
            string mahang = Nhap.NhapString();
            foreach (NhanVien NhanVien in arrayList)
            {
                if (NhanVien.Manhanvien == mahang)
                {
                    kq = NhanVien;
                }
            }
            return kq;
        }
        public static void TimKiem(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "Mã nhân viên", "Tên nhân viên", "Địa chỉ", "Số điện thoại");
            Hien(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            NhanVien ob = Find(arrayList);
          
            Console.WriteLine("Nhập mã nhân viên");
            ob.Manhanvien = Nhap.NhapString();
            Console.WriteLine("Nhập tên nhân viên");
            ob.Tennhanvien = Nhap.NhapString();
            Console.WriteLine("Nhập địa chỉ");
            ob.Diachi = Nhap.NhapString();
            Console.WriteLine("Nhập SĐT");
            ob.Sdt = Nhap.NhapString();
        }
        public static void Xoa(ArrayList arrayList)
        {
            arrayList.Remove(Find(arrayList));
        }
    }
}
