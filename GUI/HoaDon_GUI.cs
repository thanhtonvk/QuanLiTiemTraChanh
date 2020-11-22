using QuanLiTiemTraChanh.BLL;
using QuanLiTiemTraChanh.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.GUI
{
    class HoaDon_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập hóa đơn                 |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện hóa đơn                 |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Sửa                          |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  4.Xóa                          |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  5.Thoát                        |");
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
                if (chon == 5) break;
                switch (chon)
                {

                    case 1:
                        HoaDon_BLL.NhapTT(arrayList);
                        HoaDon_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        HoaDon_BLL.HienAll(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        HoaDon_BLL.HienAll(arrayList);
                        HoaDon_BLL.Sua(arrayList);
                        HoaDon_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        HoaDon_BLL.HienAll(arrayList);
                        HoaDon_BLL.Xoa(arrayList);
                        HoaDon_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
