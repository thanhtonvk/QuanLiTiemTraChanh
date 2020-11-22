using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLiTiemTraChanh.BLL;
using QuanLiTiemTraChanh.DAL;
namespace QuanLiTiemTraChanh.GUI
{
    class MatHang_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập mặt hàng                |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện mặt hàng                |");
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
                        MatHang_BLL.NhapTT(arrayList);
                        MatHang_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        MatHang_BLL.HienAll(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        MatHang_BLL.HienAll(arrayList);
                        MatHang_BLL.TimKiem(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        MatHang_BLL.HienAll(arrayList);
                        MatHang_BLL.Sua(arrayList);
                        MatHang_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        MatHang_BLL.HienAll(arrayList);
                        MatHang_BLL.Xoa(arrayList);
                        MatHang_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
