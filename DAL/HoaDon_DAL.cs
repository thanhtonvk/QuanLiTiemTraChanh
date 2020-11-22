using System;
using System.Collections;
using System.Text;
using System.IO;
using QuanLiTiemTraChanh.Entities;
namespace QuanLiTiemTraChanh.DAL
{
    class HoaDon_DAL
    {
        static string filepath = "hoadon.txt";
        public static void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new HoaDon(line.Split("#")[0], line.Split("#")[1], line.Split("#")[2], line.Split("#")[3], line.Split("#")[4],int.Parse(line.Split("#")[5]),int.Parse(line.Split("#")[6])));
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
                    foreach (HoaDon hoaDon in arrayList)
                    {
                        streamWriter.WriteLine(hoaDon.ToString());
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
