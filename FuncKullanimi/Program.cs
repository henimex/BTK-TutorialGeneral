using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action ile Func arasındaki fark : Action değer döndürmez Func Değer Döndürür.

            //Console.WriteLine(Topla(2,3));


            //Kullanım bu asamada delegeler gibi

            Func<int, int, int> add = Topla;

            Func<int> randFunc = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 50);
            };

            Func<int> rndFunc2 = () => new Random().Next(1, 100);

            Console.WriteLine(randFunc());
            Console.WriteLine(rndFunc2());
            //delegeleri yada func ları kullanırken parantez ile orneklemek gerek yoksa fonksiyonun yapısını cıktı verir.

            //Console.WriteLine(add(2,3));

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
