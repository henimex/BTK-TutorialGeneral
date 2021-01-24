using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Handle
    {
        public Handle()
        {
            
        }

        public void HataYonet(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata Alındı. Hata Mesajı");
                Console.WriteLine(ex.Message);
            }
        }


    }
}
