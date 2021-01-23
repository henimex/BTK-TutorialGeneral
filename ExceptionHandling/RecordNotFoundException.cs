using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class RecordNotFoundException:Exception
    {
        public RecordNotFoundException()
        {
            Console.WriteLine("Kayıt Bulunamadı");
        }
    }
}
