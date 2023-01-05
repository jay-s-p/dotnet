using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class car
    {
        string name;
        int mil;

        public car()
        {
            Console.WriteLine("Object Created");
        }

        public car(string name_, int mil_)
        {
            name = name_;
            mil = mil_;
            Console.WriteLine(name);
            Console.WriteLine(mil);
        }

        public car(car c)
        {
            name = c.name;
            mil = c.mil;
            Console.WriteLine(name);
            Console.WriteLine(mil);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            car c2 = new car("Tesla X", 9999);
            car c3 = new car(c2);
            Console.ReadKey();
        }
    }
}
