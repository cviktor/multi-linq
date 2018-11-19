using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    //kötelezően static class
    static class PersonExtensions
    {
        //kötelezően static metódus, és this kulcsszó változtatja extension methoddá
        //arra a típusra "aggatja rá" amelyik előtt a this szerepel
        public static void WritePerson(this Person p, int height)
        {
            Console.WriteLine(p.Name + ", " + p.Age + " és " + height + " magas");
        }
    }
}
