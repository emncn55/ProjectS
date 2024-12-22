using System;
using System.Runtime.CompilerServices;
class Constructors
{
    static void Main()
    {
        CustomerManager customerManager = new CustomerManager(20);
        //CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.List();

        Product product = new Product("Emin", 55);
        product.Read();

        EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
        employeeManager.Add();

        PersonManager personManager = new PersonManager("Emin");
        personManager.Add();

        Teacher.Number = 10; // static class
        Console.WriteLine($"Number is: {Teacher.Number}");
        Utilities.Validate(); // -> "Validation is done"





        Console.ReadLine();
    }
}
class CustomerManager
{
    int _count;
    public CustomerManager(int count) // Constructor(yapıcı), ihtiyaç duyulan parametleri almayı sağlar.
    {
        _count = count;
    }
    public CustomerManager() // overloading yapılabilir.
    {

    }

    public void List()
    {
        Console.WriteLine($"Listed! {_count} people");
    }
    public void Add()
    {
        Console.WriteLine($"Added! {_count} people");
    }

}
class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    private string _name;
    private int _id;


    public Product(string name, int id)
    {
        _name = name;
        _id = id;
    }

    public void Read()
    {
        Console.WriteLine($"Name is: {_name}, Id is: {_id}");
    }
}
interface ILogger
{
    void Log();
}
class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to Database!");
    }
}
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to File");
    }
}
class EmployeeManager
{
    private ILogger _logger;

    
    public EmployeeManager(ILogger logger)
    {
        _logger = logger;

    }

    public void Add()
    {
        _logger.Log();
        Console.WriteLine("Added!");
    }
}
class BaseClass
{
    private string _entity;
    public BaseClass(string entity)
    {
        _entity = entity;
    }
    public void Message()
    {
        Console.WriteLine($"{_entity} message");
    }
}
class PersonManager : BaseClass
{
    public PersonManager(string entity):base(entity) //base sınıfa yani "BaseClass" classına entity değerini gönderir.Constructor ile!!
    {

    }
    public void Add()
    {
        Console.WriteLine("Added!");
        Message();
    }
}
static class Teacher // static bir sınıfın herşeyi static olmak zorundadır.
{
    public static int Number { get; set; }
    
}
static class Utilities // static bir sınıfın herşeyi static olmak zorundadır.
{
    public static void Validate()
    {
        Console.WriteLine("Validation is done");
    }
}