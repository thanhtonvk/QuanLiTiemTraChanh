using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLiTiemTraChanh.Entities;
namespace QuanLiTiemTraChanh.DAL
{
    class NhanVien_DAL
    {
        static string filepath = "nhanvien.txt";
        public static void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new NhanVien(line.Split("#")[0], line.Split("#")[1], line.Split("#")[2], line.Split("#")[3]));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void GhiFile(ArrayList arrayList)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filepath))
                {
                    foreach (NhanVien nhanVien in arrayList)
                    {
                        streamWriter.WriteLine(nhanVien.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
