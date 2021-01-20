using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructuresNedir
{
    class Products
    {
        public Products()
        {
            //bos kullanabilir
        }

        int _id;
        string _name;

        public Products(int id , string name)
        {
            _id = id;
            _name = name;
            //alanları belirtmeden degerleri direk örnekleme sırasında vererek kullanabilir.
        }

        //bunları örneklerken set edebilmek icin yukardaki yapıcı metod olusturulmustur.
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
