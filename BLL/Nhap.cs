using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLiTiemTraChanh.BLL
{
    class Nhap
    {
        public static string NhapString()
        {
            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (str != "") break;
            }
            return str;
        }

        public static int NhapInt()
        {
            int fl;
            while (true)
            {
                fl = int.Parse(Console.ReadLine());
                if (fl > 0) break;
            }
            return fl;
        }
    }
}
