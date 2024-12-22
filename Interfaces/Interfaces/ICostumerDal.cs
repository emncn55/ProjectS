using System;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL added.");
        }
        public void Update()
        {
            Console.WriteLine("SQL updated.");
        }
        public void Delete()
        {
            Console.WriteLine("SQL deleted.");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }
        public void Update()
        {
            Console.WriteLine("Oracle updated.");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}