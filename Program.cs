using System;
using System.Collections;
using System.Text;
using QuanLiTiemTraChanh.GUI;

namespace QuanLiTiemTraChanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList arrayList = new ArrayList();
            DangNhap_GUI.Chon(arrayList);
        }
    }
}
