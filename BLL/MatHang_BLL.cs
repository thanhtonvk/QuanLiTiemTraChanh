using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLiTiemTraChanh.Entities;

namespace QuanLiTiemTraChanh.BLL
{
    class MatHang_BLL
    {

        public static void NhapTT(ArrayList list)
        {
            Console.WriteLine("Nhập mã mặt hàng");
            string mamh = Nhap.NhapString();
            Console.WriteLine("Nhập tên mặt hàng");
            string tenmh = Nhap.NhapString();
            Console.WriteLine("Nhập giá bán");
            int giaban = Nhap.NhapInt();
            Console.WriteLine("Nhập số lượng cũ");
            int slcu = Nhap.NhapInt();
            Console.WriteLine("Nhập số lượng mới");
            int slmoi = Nhap.NhapInt();
            list.Add(new MatHang(mamh,tenmh,giaban,slcu,slmoi));
        }
        public static void Hien(MatHang MatHang)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", MatHang.Mamathang, MatHang.Tenmathang, MatHang.Giaban, MatHang.Soluongcu, MatHang.Soluongmoi);
        }
        public static void HienAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã mặt hàng", "Tên mặt hàng", "Giá bán", "Số lượng cũ", "Số lượng mới");
            foreach (MatHang MatHang in arrayList)
            {
                Hien(MatHang);
            }
        }
        public static MatHang Find(ArrayList arrayList)
        {
            MatHang kq = null;
            Console.WriteLine("Nhập mã hóa đơn:");
            string mahang = Nhap.NhapString();
            foreach (MatHang MatHang in arrayList)
            {
                if (MatHang.Mamathang == mahang)
                {
                    kq = MatHang;
                }
            }
            return kq;
        }
        public static void TimKiem(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã mặt hàng", "Tên mặt hàng", "Giá bán", "Số lượng cũ", "Số lượng mới");
            Hien(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            MatHang ob = Find(arrayList);
            Console.WriteLine("Nhập mã mặt hàng");
           ob.Mamathang = Nhap.NhapString();
            Console.WriteLine("Nhập tên mặt hàng");
            ob.Tenmathang= Nhap.NhapString();
            Console.WriteLine("Nhập giá bán");
           ob.Giaban = Nhap.NhapInt();
            Console.WriteLine("Nhập số lượng cũ");
            ob.Soluongcu= Nhap.NhapInt();
            Console.WriteLine("Nhập số lượng mới");
            ob.Soluongmoi= Nhap.NhapInt();
        }
        public static void Xoa(ArrayList arrayList)
        {
            arrayList.Remove(Find(arrayList));
        }
    }
}

