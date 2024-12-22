using System;
class AccessModifiers
{
    static void Main()
    {

    }
}
class Customer
{
    //private int id { get; set; } sadece tanımlandığı blokta kullanılabilir(Customer)
    //protected int Id { get; set; } tanımlandığı blokta ve inherit edildiği blokta kullanılabilir(Customer,Student)
    public void Delete()
    {

    }
    public void Save()
    {

    }

}
class Student : Customer
{
    public void Save2()
    {
        Customer customer = new Customer();
    }
}
internal class Course  // bağlı olduğu proje içinde bu projeyi referans ihtiyacı olmadan kullanabilirsiniz internal sayesinde.
{
    public string Name { get; set; }

}
public class Asadmlaskmclas // proje dışında başka projelerde de kullanabilmek için diğer projeye using AccessModifiers eklenmelidir ve class public yapılmalıdır.
{

}