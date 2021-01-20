using System;


namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Database db = new Mysql();
            db.Add();
            db.Delete();

            Database db2 = new SqlServerDB();
            db2.Add();
            db2.Delete();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Standart ekleme komutları ile Eklendi");
        }

        public abstract void Delete();
    }

    class Mysql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by mysql");
        }
    }


    class SqlServerDB : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }

    class
}
