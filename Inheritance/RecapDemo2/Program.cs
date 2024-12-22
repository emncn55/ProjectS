using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();


            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Logger logger = new Logger();
            logger.Log();
            Console.WriteLine("Customer added.");
        }
    }
    class Logger
    {
        public void Log()
        {
            Console.WriteLine("Logged!");
        }
    }
}
