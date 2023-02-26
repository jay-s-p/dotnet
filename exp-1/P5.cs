/*
Write a C# program for finding area of 
different shapes using method overloading.
*/
using System;

namespace Zzz
{
    class A
    {
        public void area(int l)
        {
            double ans = l * l;
            Console.WriteLine("Area Of Square having " + l + " length is : " + ans);
        }
        public void area(int l, int w)
        {
            double ans = l * w;
            Console.WriteLine("Area of Rectangle having length " + l + " and width " + w + " is : " + ans);
        }
        public void area(double pi, int r)
        {
            double ans = pi * r * r;
            Console.WriteLine("Area of circle having radius " + r + " is : " + ans);
        }
        public void area(int a, int b, int c)
        {
            int s = (a + b + c);
            double ans = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area of Triangle is : " + ans);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.area(8);
            a.area(2, 3);
            a.area(3.14, 2);
            a.area(3, 3, 3);

            Console.ReadKey();
        }
    }
}
