using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        //Mutlaka Lazım olacak bir yapı. İyice Sindirilmesi Katmanlı Mimaride Tasarımı Araştırılmalı.
        //Bunu bilmeden önce ben bu olayı timer ile yapmaya calısırdım ki oda cok fazla kaynak yerdi diye düşünüyorum.
        //Counter
        static void Main(string[] args)
        {
            Product hardDisk= new Product(50);
            hardDisk.ProductName = "HardDisk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;
            
            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm Stock In Critic Stock");
        }
    }
}
