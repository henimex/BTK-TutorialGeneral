using System;

namespace Inheritance_Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cm = new Customer();
            cm.name = "Ferhat";
            cm.City = "Eskişehir";
            cm.newProp = "new prop";


            Student st = new Student();
            st.name = "Esila";
            st.Department = "6/B";

            Person[] people = new Person[3] // x persons * people //dalmıs gitmis hocam
            {
                new Customer{ name = "Ali" }, new Student{  name = "Esila"}, new Person {name ="Dilek"}
            };

            foreach (var item in people)
            {
                Console.WriteLine(item.name);
            }
        }
    }

    interface ICustomer
    {
        void Member();
    }

    interface IStudent
    {
        public int addStudent { get; set; }
    }

    class Person:otherPerson
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }

    class Customer : Person,ICustomer,IStudent //bir sınıf inheritance yaparken sadece bir tek sınıftan kalıtılabilir. bir kişinin bir babası olur. ama ınterface olarak birden fazla verilebilir. sadece kalıtım once verilmelidir.
    {
        public string City { get; set; }
        
        public int addStudent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Member()
        {
            throw new NotImplementedException();
        }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

    class otherPerson
    {
        public string newProp { get; set; }
    }
}
