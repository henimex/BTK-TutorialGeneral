using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1,  LastName = "Oygur", Age = 37 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            customerDal.AddNew(customer);

            Customer customer2 = new Customer() {Age = 10, Id = 1};
            customerDal.AddNew(customer2);

            Console.ReadLine();
        }
    }

    [ToTable("Customer")]
    [ToTable("TblCustomer")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProp]
        public string FirstName { get; set; }
        [RequiredProp]
        public string LastName { get; set; }
        [RequiredProp]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Değişiklik Notu")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2} added.", customer.FirstName, customer.LastName, customer.Age);
        }
        
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2} added.", customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    class RequiredPropAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

    
}
