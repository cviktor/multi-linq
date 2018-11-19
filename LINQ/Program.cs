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

            //WritePerson(new Person() { Name = "Béla", Age = 5 });

            //anonymus type példa
            var anonymus = new { Name = "Morzsi", Age = 3 };
            //ha egyezik az adattagok neve, típusa, sorrendje akkor ugyanolyan típusnak felel meg
            var anonymus2 = new { Name = "Béla", Age = 10 };

            Console.ReadKey();
        }

        static void WritePerson(Person p)
        {
            Console.WriteLine(p.Name + ", " + p.Age);
        }

    }
}
