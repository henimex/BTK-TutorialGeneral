using System;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager studentManager = new StudentManager();
            IPersonManager internManager = new Internt();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(studentManager);
            projectManager.Add(internManager);
            
            //customerManager.Add();
            //studentManager.Add();
        }
    }

    interface IPersonManager //Manager yazdık içini boş buraktık cunku burda bi operasyon tanımlıcaz prop degil.
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class StudentManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Öğrenci Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Student Güncellendi");
        }
    }

    class Internt : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Intern Guncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }

        public void Update(IPersonManager person)
        {
            person.Update();
        }
    }
}
