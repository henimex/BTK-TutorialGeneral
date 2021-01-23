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
            string[] cities = new string[2] { "Ferhat", "Esila" };
            Console.WriteLine(cities[0]);
            cities = new string[3];
            Console.WriteLine(cities[0]);
           

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

            Console.WriteLine("Son Eleman : {0}", newCities[newCities.Count - 1]);

            newCities.Add(1);
            newCities.Add(true);
            newCities.Add('A');

            foreach (var city in newCities)
            {
                Console.WriteLine(city);
            }

            List<string> ogrenciler = new List<string>();
            ogrenciler.Add("Ferhat");
            ogrenciler.Add("Dilek");

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            bool ogrenciVarmi = ogrenciler.Contains("Dilek");
            Console.WriteLine("Ogrenci Varmı Sonucu : {0}", ogrenciVarmi);
            if (ogrenciVarmi)
            {
                Console.WriteLine("Evet Ogrenci Var");
            }
            else
            {
                Console.WriteLine("Aradıgınız ogrenci listede bulunamadı");
            }

            

            Customer customer = new Customer();
            customer.FirstName = "Amazın";
            customer.Id = 1;

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "e-Bay"
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(customer);    
            customers.Add(customer2);

            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }

            customers.AddRange(new Customer[3]
            {
                new Customer{Id = 5, FirstName= "Robot"},
                new Customer{Id = 6, FirstName= "Prenses"},
                new Customer{Id = 7, FirstName= "Süpürge"}
            });

            customers.Contains(customer2);

            var index = customers.IndexOf(customer);
            var lastIndex = customers.LastIndexOf(customer2);
            customers.Insert(0, customer);
            customers.RemoveAll(x => x.FirstName == "Robot");
            Console.WriteLine(index);
            Console.WriteLine(lastIndex);
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

       //public string CustomerNames
       // {
       //     get { return FirstName; }
       // }
    }
}
