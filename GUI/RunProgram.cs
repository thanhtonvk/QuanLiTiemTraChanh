using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLiTiemTraChanh.BLL;
using QuanLiTiemTraChanh.DAL;
using QuanLiTiemTraChanh.Entities;
using QuanLiTiemTraChanh.GUI;
using System.IO;

namespace QuanLiTiemTraChanh.GUI
{
    class RunProgram
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Quản lí mặt hàng             |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Quản lí nhân viên            |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Quản lí giá bán              |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  4.Quản lí hóa đơn              |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  5.Báo cáo thống kê             |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  6.Thoát                        |");
            Console.WriteLine("---------------------------------------------------");
        }
        static ArrayList mathang = new ArrayList();
        static ArrayList nhanvien = new ArrayList();
        static ArrayList giaban = new ArrayList();
        static ArrayList hoadon = new ArrayList();
        static ArrayList thongke = new ArrayList();
        
        public static void Run()
        {
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 6) break;
                switch (chon)
                {
                    case 1:
                        MatHang_DAL.DocFile(mathang);
                        MatHang_GUI.Chon(mathang);
                        break;
                    case 2:
                        NhanVien_DAL.DocFile(nhanvien);
                        NhanVien_GUI.Chon(nhanvien);
                        break;
                    case 3:
                        GiaBan_DAL.DocFile(giaban);
                        GiaBan_GUI.Chon(giaban);
                        break;
                    case 4:
                        HoaDon_DAL.DocFile(hoadon);
                        HoaDon_GUI.Chon(hoadon);
                        break;
                    case 5:
                        BaoCaoThongKe_DAL.DocFile(thongke);
                        BaoCaoThongKe_GUI.Chon(thongke);
                        break;
                    
                    default: break;

                }

            }
        }
    }
}
