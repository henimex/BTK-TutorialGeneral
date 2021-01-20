using System;


namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SQLSERVER sql = new SQLSERVER();
            MYSQLSERVER my = new MYSQLSERVER();

            sql.Add("test server");
            my.Add("test2 server");
            sql.Delete();
            my.Delete();
        }
    }

    class Database
    {
        
        public virtual void Add(string dbname)
        {
            //ezilebilmesini saglayan virtual olmasıdır
            Console.WriteLine("added " + dbname);
        }

        public void Delete()
        {
            Console.WriteLine("deleted");
        }
    }

    class SQLSERVER:Database
    {
        public override void Add(string dbname)
        {
            dbname = "SQLSERVER";
            Console.WriteLine("Önce Değer verildi yada düzenleme yapıldı sonradan standart kod cagrıldı");
            base.Add(dbname);
        }
    }

    class MYSQLSERVER:Database
    {

    }
}
