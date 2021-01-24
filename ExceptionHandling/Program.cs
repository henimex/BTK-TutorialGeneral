using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            

            HataYonet2(() =>
            {
                Find();
            });
            Console.ReadLine();
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ferhat", "Dilek", "Esila", "Ali Alp" };

            if (students.Contains("Ali"))
            {
                Console.WriteLine("Kayıt Bulundu");
            }
            else
            {
                Console.WriteLine("Aradığınız Kayıt Bulundu");
            }
        }

        private static void HataYonet2(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata Alındı. Hata Mesajı");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
