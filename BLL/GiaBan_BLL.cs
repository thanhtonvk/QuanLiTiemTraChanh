using QuanLiTiemTraChanh.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.BLL
{
    class GiaBan_BLL
    {
        public static void NhapTT(ArrayList list)
        {
            Console.WriteLine("Nhập tên hàng");
            string tenhang = Nhap.NhapString();
            Console.WriteLine("Nhập mã hàng");
            string mahang = Nhap.NhapString();
            Console.WriteLine("Nhập giá bán");
            int giaban = Nhap.NhapInt();
            Console.WriteLine("Nhập giá nhập");
            int gianhap = Nhap.NhapInt();
            list.Add(new GiaBan(tenhang, mahang, giaban, gianhap));
        }
        public static void Hien(GiaBan giaBan)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", giaBan.Tenhang, giaBan.Mahang, giaBan.Giaban, giaBan.Gianhap);
        }
        public static void HienAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "Tên hàng", "Mã hàng", "Gia bán", "Giá nhập");
            foreach (GiaBan giaBan in arrayList)
            {
                Hien(giaBan);
            }
        }
        public static GiaBan Find(ArrayList arrayList)
        {
            GiaBan kq = null;
            Console.WriteLine("Nhập mà hàng:");
            string mahang = Nhap.NhapString();
            foreach (GiaBan giaBan in arrayList)
            {
                if (giaBan.Mahang == mahang)
                {
                    kq = giaBan;
                }
            }
            return kq;
        }
        public static void Sua(ArrayList arrayList)
        {
            GiaBan ob = Find(arrayList);
            Console.WriteLine("Nhập tên hàng");
            ob.Tenhang = Nhap.NhapString();
            Console.WriteLine("Nhập mã hàng");
            ob.Mahang = Nhap.NhapString();
            Console.WriteLine("Nhập giá bán");
            ob.Giaban = Nhap.NhapInt();
            Console.WriteLine("Nhập giá nhập");
            ob.Gianhap = Nhap.NhapInt();
        }
        public static void Xoa(ArrayList arrayList)
        {
            arrayList.Remove(Find(arrayList));
        }
    }
}
