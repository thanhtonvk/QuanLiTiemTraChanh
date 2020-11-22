using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using QuanLiTiemTraChanh.BLL;
using QuanLiTiemTraChanh.DAL;
namespace QuanLiTiemTraChanh.GUI
{
    class NhanVien_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập nhân viên               |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện nhân viên               |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Tìm kiếm                     |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  4.Sửa                          |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  5.Xóa                          |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  6.Thoát                        |");
            Console.WriteLine("---------------------------------------------------");
        }
        public static void Chon(ArrayList arrayList)
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
                        NhanVien_BLL.NhapTT(arrayList);
                        NhanVien_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        NhanVien_BLL.HienAll(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        NhanVien_BLL.HienAll(arrayList);
                        NhanVien_BLL.TimKiem(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        NhanVien_BLL.HienAll(arrayList);
                        NhanVien_BLL.Sua(arrayList);
                        NhanVien_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        NhanVien_BLL.HienAll(arrayList);
                        NhanVien_BLL.Xoa(arrayList);
                        NhanVien_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
