using System;
using System.Collections;
using System.Text;
using System.IO;
using QuanLiTiemTraChanh.Entities;


namespace QuanLiTiemTraChanh.DAL
{
    class GiaBan_DAL
    {
        static string filepath = "giaban.txt";
        public static void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new GiaBan(line.Split("#")[0],line.Split("#")[1],int.Parse(line.Split("#")[2]),int.Parse(line.Split("#")[3])));
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
                    foreach (GiaBan giaBan in arrayList)
                    {
                        streamWriter.WriteLine(giaBan.ToString());
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

