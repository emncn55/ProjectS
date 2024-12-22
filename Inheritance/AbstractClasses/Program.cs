using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database dataBase = new SqlServer();
            Database dataBase1 = new OracleServer();
            dataBase.Add();
            dataBase.Delete();
            dataBase.Add();
            dataBase1.Delete();


            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by Default.");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("silme işlemi sql'e uygundur.");
        }
    }
    class OracleServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Silme işlemi Oracle'a uygundur.");
        }
    }
}
