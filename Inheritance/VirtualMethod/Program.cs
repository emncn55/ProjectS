using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database dataBase = new Database();
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();

            dataBase.Add();
            sqlServer.Add();
            mySql.Add();


            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default.");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by Default.");
        }
    }
    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("virtual ve override sayesinde burası çalıştı.");
            //base.Add();
        }
    }
    class MySql:Database
    {

    }
}
