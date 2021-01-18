using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceKullanimi
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
            //deneme
            //deneme onaylandı
        }
    }
}
