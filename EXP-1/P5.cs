/*
Write C# program to perform multilevel
inheritance.
*/
using System;

namespace Zzz
{
    class A
    {
        public void area(int a)
        {
            double ans = 3.14 * a * a;
            Console.WriteLine("Area of circle having radius " + a + " is " + ans);
        }
        public void area(int a, int b)
        {
            double ans = a * b;
            Console.WriteLine("Area of ractangle having length " + a + " is " + ans);
        }
        public void area(double a)
        {
            double ans = 3.14 * a * a;
            Console.WriteLine("Area of circle having radius " + a + " is " + ans);
        }
        public void area(double a, double b)
        {
            double ans = a * b;
            Console.WriteLine("Area of ractangle having length " + a + " is " + ans);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A.area(10);
            A.area(2,3);
            A.area(20.52);
            A.area(10.2, 5.7);

            Console.ReadKey();
        }
    }
}
