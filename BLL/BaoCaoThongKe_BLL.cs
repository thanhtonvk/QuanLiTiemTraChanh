using QuanLiTiemTraChanh.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.BLL
{
    class BaoCaoThongKe_BLL
    {
        public static void NhapTT(ArrayList list)
        {
            Console.WriteLine("Nhập mã hóa đơn");
            string mahoadon = Nhap.NhapString();
            Console.WriteLine("Nhập tên mặt hàng");
            string tenmathang = Nhap.NhapString();
            Console.WriteLine("Nhập tổng tiền");
            int tongtien = Nhap.NhapInt();
            list.Add(new BaoCaoThongKe(mahoadon,tenmathang,tongtien));
        }
        public static void Hien(BaoCaoThongKe baoCaoThongKe)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", baoCaoThongKe.Mahoadon, baoCaoThongKe.Tenmathang, baoCaoThongKe.Tongtien);
        }
        public static void HienAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "Mã hóa đơn","Tên mặt hàng","Tổng tiền");
            foreach (BaoCaoThongKe baoCaoThongKe in arrayList)
            {
                Hien(baoCaoThongKe);
            }
        }
    }
}
