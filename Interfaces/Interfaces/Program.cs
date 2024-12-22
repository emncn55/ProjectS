using Interfaces;
using System;
class Program
{
    static void Main(string[] args)
    {
        ICustomerDal[] customerDals = new ICustomerDal[]
        {
            new SqlServerCustomerDal(),
            new OracleServerCustomerDal()
        };

        // Execute operations for each ICustomerDal
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
            customerDal.Update();
            customerDal.Delete();
        }

        Console.ReadLine();
    }

    /*private static void Demo2()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
    }*/
    /*
private static void Interfaces()
{
   PersonManager manager = new PersonManager();
   Customer customer = new Customer()
   {
       FirstName = "Emin",
       LastName = "Can",
       Id = 55
   };
   Student student = new Student()
   {
       FirstName = "Nisa",
       LastName = "Nur",
       Id = 60
   };
   manager.Add(customer);
   manager.Add(student);
}
}
class IPerson
{
int Id { get; set; }
string FirstName { get; set; }
string LastName { get; set; }

}
class Customer : IPerson
{
public int Id { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public string Address { get; set; }

}
class Student : IPerson
{
public int Id { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public string Department { get; set; }

}
//class PersonManager
{
//public void Add(IPerson person)
{
   Console.WriteLine(person.FirstName);
}*/
}