using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACMod_Start;
//classı kullanabilmek icin using e ekleniyor.

namespace ACMod_Use
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanılacak proje calısan projenin referanslarına ekleniyor
            ModeStartClass mu = new ModeStartClass(); // diger projede olan class burda ornekleniyor.
            mu.Tester();
            Console.ReadLine();
        }
    }
}
