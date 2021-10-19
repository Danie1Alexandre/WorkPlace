using System;
using WorkPlace.Model;

namespace WorkPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person0 = new Person();
            person0.Name = "per son";
            person0.Phone = "+4612345";
            person0.ContactAdress = "Skövde, Bogatan 4";

            Employee employee0 = new Employee();
            employee0.Name = "kalle son";
            employee0.Phone = "+4647888";
            employee0.ContactAdress = "Skövde, Bogatan 8";
            employee0.Salery = 1000000;

            Administrator administrator0 = new Administrator();
            administrator0.Name = "employee son";
            administrator0.Phone = "+4647888";
            administrator0.ContactAdress = "Skövde, Bogatan 8";
            administrator0.Salery = 1000000;
            administrator0.Bonus = 1000;

            Console.WriteLine(person0.Info());
            Console.WriteLine(employee0.Info());
            Console.WriteLine(administrator0.Info());
            Console.ReadKey();


        }
    }
}
