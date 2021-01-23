using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(26, "Eskişehir");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(16, "Bursa");
            plakalar.Add(06, "Ankara");

            foreach (var item in plakalar)
            {
                Console.WriteLine("Plaka Numarası \t: {0} \t Şehir Adı \t: {1}",item.Key,item.Value);
            }
            
            Console.ReadLine();
        }
    }
}
