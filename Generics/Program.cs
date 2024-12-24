using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Costumer> result2 = utilities.BuildList<Costumer>(new Costumer { FirstName = "Emin" }, new Costumer { FirstName = "Derin" });
            foreach (var costumer in result2)
            {
                Console.WriteLine(costumer.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product
    {

    }
    interface IProductDal : IRepository<Product>
    {
        
    }
    class Costumer
    {
        public string FirstName { get; set; }
    }
    interface ICostumerDal : IRepository<Costumer>
    {
        
    }
    interface IRepository<T>
    {
        List<T> GetAll();
        T GetProduct(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICostumerDal
    {
        public void Add(Costumer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Costumer entity)
        {
            throw new NotImplementedException();
        }

        public List<Costumer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Costumer GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Costumer entity)
        {
            throw new NotImplementedException();
        }
    }
}
