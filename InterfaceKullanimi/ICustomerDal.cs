using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceKullanimi
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleDBCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class FireBaseIcustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("FireBase Added");
        }

        public void Delete()
        {
            Console.WriteLine("FireBase Deleted");
        }

        public void Update()
        {
            Console.WriteLine("FireBase Updated");
        }
    }
}
