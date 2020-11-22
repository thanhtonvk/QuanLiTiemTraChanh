using System;
using System.Collections;
using System.Text;
using System.IO;
using QuanLiTiemTraChanh.Entities;
namespace QuanLiTiemTraChanh.DAL
{
    class MatHang_DAL
    {
        static string filepath = "mathang.txt";
        public static void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new MatHang(line.Split("#")[0],line.Split("#")[1],int.Parse(line.Split("#")[2]), int.Parse(line.Split("#")[3]), int.Parse(line.Split("#")[4])));
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
                    foreach (MatHang matHang in arrayList)
                    {
                        streamWriter.WriteLine(matHang.ToString());
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
