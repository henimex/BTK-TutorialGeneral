using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructuresNedir
{
    class ConManager
    {
        int _pageCount = 15;

        public ConManager(int pageCount)
        {
            _pageCount = pageCount;
        }

        public ConManager()
        {

        }

        public void List()
        {
            Console.WriteLine("{0} sayfa Listelendi.",_pageCount);
        }
    }
}
