using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLiTiemTraChanh.Entities;

namespace QuanLiTiemTraChanh.BLL
{
    class HoaDon_BLL
    {
        public static void NhapTT(ArrayList list)
        {
            Console.WriteLine("Nhập mã hóa đơn");
            string mahoadon = Nhap.NhapString();
            Console.WriteLine("Nhập tên hóa đơn");
            string tenhoadon = Nhap.NhapString();
            Console.WriteLine("Nhập tên nhân viên bán");
            string tennhanvienban = Nhap.NhapString();
            Console.WriteLine("Nhập mã hàng");
            string mahang = Nhap.NhapString();
            Console.WriteLine("Nhập tên hàng");
            string tenhang = Nhap.NhapString();
            Console.WriteLine("Nhập số lượng");
            int soluong = Nhap.NhapInt();
            Console.WriteLine("Nhập giá bán");
            int giaban = Nhap.NhapInt();
            list.Add(new HoaDon(mahoadon, tenhoadon, tennhanvienban, mahang, tenhang, soluong, giaban));
        }
        public static void Hien(HoaDon HoaDon)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", HoaDon.Mahoadon, HoaDon.Tenhoadon, HoaDon.Tennhanvienban, HoaDon.Mahang, HoaDon.Tenhang, HoaDon.Soluong, HoaDon.Giaban);
        }
        public static void HienAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "Mã hóa đơn", "Tên hóa đơn", "Tên nhân viên bán", "Mã hàng", "Tên hàng", "Số lượng", "Giá bán");
            foreach (HoaDon HoaDon in arrayList)
            {
                Hien(HoaDon);
            }
        }
        public static HoaDon Find(ArrayList arrayList)
        {
            HoaDon kq = null;
            Console.WriteLine("Nhập mã hóa đơn:");
            string mahang = Nhap.NhapString();
            foreach (HoaDon HoaDon in arrayList)
            {
                if (HoaDon.Mahoadon == mahang)
                {
                    kq = HoaDon;
                }
            }
            return kq;
        }
        public static void TimKiem(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "Mã hóa đơn", "Tên hóa đơn", "Tên nhân viên bán", "Mã hàng", "Tên hàng", "Số lượng", "Giá bán");
            Hien(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            HoaDon ob = Find(arrayList);
            Console.WriteLine("Nhập mã hóa đơn");
            ob.Mahoadon = Nhap.NhapString();
            Console.WriteLine("Nhập tên hóa đơn");
            ob.Tenhoadon = Nhap.NhapString();
            Console.WriteLine("Nhập tên nhân viên bán");
            ob.Tennhanvienban = Nhap.NhapString();
            Console.WriteLine("Nhập mã hàng");
            ob.Mahang = Nhap.NhapString();
            Console.WriteLine("Nhập tên hàng");
            ob.Tenhang = Nhap.NhapString();
            Console.WriteLine("Nhập số lượng");
            ob.Soluong = Nhap.NhapInt();
            Console.WriteLine("Nhập giá bán");
            ob.Giaban = Nhap.NhapInt();
        }
        public static void Xoa(ArrayList arrayList)
        {
            arrayList.Remove(Find(arrayList));
        }
    }
}
