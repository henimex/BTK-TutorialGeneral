using System;

namespace InterfaceKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceIntro();
            ICustomerDal customerDal = new OracleDBCustomerDal();
            customerDal.Add();

            ICustomerDal customerDal2 = new FireBaseIcustomerDal();
            customerDal2.Add();

            ICustomerDal customerDal3 = new SqlServerCustomerDal();
            customerDal3.Add();

            CustomerManager cm = new CustomerManager();
            cm.Add(new OracleDBCustomerDal());

            CustomerManager cm2 = new CustomerManager();
            cm2.Add(new FireBaseIcustomerDal());

            CustomerManager cm3 = new CustomerManager();
            cm3.Add(new SqlServerCustomerDal());
        }

        private static void InterfaceIntro()
        {
            PersonManager pm = new PersonManager();

            Student student2 = new Student()
            {
                Id = 1,
                FirstName = "Ali Alp OYGUR",
                LastName = "Oygur",
                ClassName = "2/B"
            };

            pm.Add(new Customer { Id = 1, FirstName = "Ferhat", LastName = "Oygur", Adress = "Eskişehir" });

            Customer customer2 = new Customer()
            {
                Id = 1,
                FirstName = "Dilek",
                LastName = "Oygur",
                Adress = "Eskişehir"
            };

            pm.NewAdd(student2); //IPerson dan enkapsule edilen hersey bu metodda kullanılabilir
            pm.NewAdd(customer2);
            //pm.Add(student2); // İkiside IPersondan enkapsule olsa bile sadece istenilen sınıftan veri gönderilebilir.
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string ClassName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Adress { get; set; }
        }

        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " Standart Yöntem ile Listeye Eklendi");
            }

            public void NewAdd(IPerson person)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " Interface Yöntemi ile Listeye Eklendi");
            }
        }
    }
}
