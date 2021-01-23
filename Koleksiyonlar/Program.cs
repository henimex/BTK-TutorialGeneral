using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[2]{ "Ferhat","Esila"};
            Console.WriteLine(cities[0]);
            cities = new string[3];
            Console.WriteLine(cities[0]);
            Console.ReadLine();

            ArrayList newCities = new ArrayList();
            newCities.Add("Akıllı Ali");
            newCities.Add("Dr.Esila");
            newCities.Add("Dilek");

            Console.WriteLine(newCities[0]);

            foreach (var city in newCities)
            {
                Console.WriteLine(city);
            }

            newCities.Add("Ferhat");

            Console.WriteLine("Son Eleman : {0}",newCities[newCities.Count-1]);

            newCities.Add(1);
            newCities.Add(true);
            newCities.Add('A');

            foreach (var city in newCities)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}
