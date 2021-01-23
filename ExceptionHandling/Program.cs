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
            List<string> students = new List<string> { "Ferhat", "Dilek", "Esila", "Ali Alp" };

            if (!students.Contains("Ali"))
            {
                throw new RecordNotFoundException();
            }
            else
            {
                Console.WriteLine("Aradığınız Kayıt Bulundu");
            }

            Console.ReadLine();
        }
    }
}
