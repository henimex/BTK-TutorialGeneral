using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructuresNedir
{
    class BaseClass
    {
        private string _entity;

        public BaseClass(string entiy)
        {
            _entity = entiy;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }


    }
}
