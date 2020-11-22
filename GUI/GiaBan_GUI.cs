using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLiTiemTraChanh.DAL;
using QuanLiTiemTraChanh.BLL;
using System.Collections;

namespace QuanLiTiemTraChanh.GUI
{
    class GiaBan_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập giá bán                 |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện giá bán                 |");
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
                        GiaBan_BLL.NhapTT(arrayList);
                        GiaBan_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        GiaBan_BLL.NhapTT(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        GiaBan_BLL.HienAll(arrayList);
                        GiaBan_BLL.Sua(arrayList);
                        GiaBan_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        GiaBan_BLL.HienAll(arrayList);
                        GiaBan_BLL.Xoa(arrayList);
                        GiaBan_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
