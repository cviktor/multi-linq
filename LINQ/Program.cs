using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    delegate bool FilterDelegate(int number);

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
            //var anonymus = new { Name = "Morzsi", Age = 3 };
            //ha egyezik az adattagok neve, típusa, sorrendje akkor ugyanolyan típusnak felel meg
            //var anonymus2 = new { Name = "Béla", Age = 10 };


            //Extension method példa
            //var p = new Person()
            //{
            //    Name = "Béla",
            //    Age = 5
            //};

            //a két hívás végeredményben megegyezik csak máshogy néz ki
            //PersonExtensions.WritePerson(p, 187);
            //p.WritePerson(187);

            //a lista egy dinamikusan nyújtozkodó tömb szerű adattároló
            //rögtön fel is töltöm elemekkel de ez nem kötelező olyan mintha utána hívnék 10 darab
            //numbers.Add()-ot
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var evenNumbers = FilterEven(numbers);

            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            //var oddNumbers = FilterOdd(numbers);

            //foreach (var num in oddNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            //fontos hogy az IsEven mögé nem írjuk oda a ()-eket
            //mert akkor meghívjuk és az eredményét adjuk be paraméterbe

            FilterDelegate f = MyMethod;

            var filtered = Filter(numbers, f);

            foreach (var num in filtered)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }

        static bool MyMethod(int x)
        {
            return x > 3 && x % 2 == 0 && x < 10;
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static List<int> Filter(List<int> nums, FilterDelegate del)
        {
            var result = new List<int>();

            foreach (var num in nums)
            {
                bool res = del(num);
                if (res)
                {
                    result.Add(num);
                }
            }

            return result;
        }

        static List<int> FilterEven(List<int> nums)
        {
            var result = new List<int>();

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            return result;
        }

        static List<int> FilterOdd(List<int> nums)
        {
            var result = new List<int>();

            foreach (var num in nums)
            {
                if (num % 2 == 1)
                {
                    result.Add(num);
                }
            }

            return result;
        }

        static List<int> FilterGreaterThan(List<int> nums, int min)
        {
            var result = new List<int>();

            foreach (var num in nums)
            {
                if (num > min)
                {
                    result.Add(num);
                }
            }

            return result;
        }

    }
}
