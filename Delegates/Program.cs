using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int n1, int n2);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Naber yavru");

            MyDelegate3 myDelegate3 = matematik.Topla;
            var sonuc = myDelegate3(5, 6);
            Console.WriteLine(sonuc);


            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Becarefull");
        }

        public void SendMessage2(string text)
        {
            Console.WriteLine("İKinci delege " + text);
        }

        public void ShowAlert2(string text)
        {
            Console.WriteLine("İkinci delege " + text);
        }
    }

    public class Matematik
    {
        public int Topla(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
