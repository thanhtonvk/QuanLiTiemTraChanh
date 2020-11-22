using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLiTiemTraChanh.BLL;
using QuanLiTiemTraChanh.DAL;
namespace QuanLiTiemTraChanh.GUI
{
    class BaoCaoThongKe_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập thống kê                |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện thống kê                |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Thoát                        |");
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
                if (chon == 3) break;
                switch (chon)
                {

                    case 1:
                        BaoCaoThongKe_BLL.NhapTT(arrayList);
                        BaoCaoThongKe_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        BaoCaoThongKe_BLL.HienAll(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default: break;


                }
            }
        }
    }
}
