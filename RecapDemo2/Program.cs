using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager();
            cm.Logger = new DatabaseLogger();
            //              FileLogger();
            //              SmsLogger

            cm.Add();
        }
    }

    class CustomerManager
    {
        public IILogger Logger { get; set; }
        public void Add()
        {
            Console.WriteLine("Customer Added");
            Logger.Log();
        }
    }

    class DatabaseLogger : IILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : IILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To File");
        }
    }

    class SmsLogger : IILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To SMS");
        }
    }

    interface IILogger
    {
        void Log();
    }

}
