using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //var kulcsszó
            var number = 3;

            //var person = new Person();
            //person.Name = "Béla";
            //person.Age = 3;

            //object initializer
            //var person = new Person()
            //{
            //    Name = "Béla",
            //    Age = 5
            //};
            //WritePerson(person);

            WritePerson(new Person() { Name = "Béla", Age = 5 });

            Console.ReadKey();
        }

        static void WritePerson(Person p)
        {
            Console.WriteLine(p.Name + ", " + p.Age);
        }

    }
}
