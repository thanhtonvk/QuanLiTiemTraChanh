using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLiTiemTraChanh.Entities;
namespace QuanLiTiemTraChanh.DAL
{
    class BaoCaoThongKe_DAL
    {
        static string filepath = "baocaothongke.txt";
        public static void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new BaoCaoThongKe(line.Split("#")[0],line.Split("#")[1],int.Parse(line.Split("#")[2])));
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
                    foreach (BaoCaoThongKe baoCaoThongKe in arrayList)
                    {
                        streamWriter.WriteLine(baoCaoThongKe.ToString());
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
