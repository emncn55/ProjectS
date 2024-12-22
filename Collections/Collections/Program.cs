using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        //ArrayList();
        //List();
        Dictionary<string,string> dictionary = new Dictionary<string,string>();
        dictionary.Add("book", "kitap");
        dictionary.Add("table", "tablo");
        dictionary.Add("computer", "bilgisayar");

        Console.WriteLine(dictionary["table"]); // key - value mantığıyla çalışır.yani "table" anahtar kelimesini arattığımızda bize "tablo" değerini verir
        Console.WriteLine(dictionary["book"]);
        Console.WriteLine(dictionary["computer"]);
        foreach (var item in dictionary)
        {
            Console.WriteLine(item); // [book, kitap] [table, tablo] [computer, bilgisayar]
            Console.WriteLine(item.Value);
            Console.WriteLine(item.Key);
        }
        Console.WriteLine(dictionary.ContainsKey("book")); // True döndürür.


        Console.ReadLine();
    }

    private static void List()
    {
        List<string> cities = new List<string>(); //tip güvenli bir koleksiyondur.
        cities.Add("Emin");

        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
        //List<Customer> customers = new List<Customer>();
        //customers.Add(new Customer { Id = 55, Name = "Emin" });

        List<Customer> customers = new List<Customer>
        {
            new Customer {Id=55,Name="Emin"},
            new Customer {Id=44,Name="Ahmet"}
        };

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
        var count = customers.Count;
        Console.WriteLine(count);
        customers.AddRange(new Customer[2]
        {
            new Customer {Name="Emin",Id=55},
            new Customer {Name="Muhsin",Id=34}
        });
        foreach (var cs in customers)
        {
            Console.WriteLine(cs.Name);
            Console.WriteLine(cs.Id);
        }
        var customer2 = new Customer
        {
            Name = "Emin",
            Id = 56
        };
        customers.Insert(0, customer2); //0. indexe customer2 yi eklemiş oluruz Insert ile
        //customer.Clear();
        customers.Add(customer2);
        var index = customers.IndexOf(customer2);
        Console.WriteLine($"index: {index}");
        var index2 = customers.LastIndexOf(customer2);
        Console.WriteLine($"index2: {index2}");
    }

    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    private static void ArrayList()
    {
        ArrayList cities = new ArrayList();
        cities.Add("Ankara");
        cities.Add("Isntanbul");

        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
        cities.Add("Bursa");
        Console.WriteLine(cities[2]);
    }
}