/*
Write a C# code to Convert following
currency conversion.
Rupees to dollar, frank, euro.
*/
using System;

namespace Zzz
{
    class RupeeConverter
    {
        public double toDollar(double x)
        {
            return x * 0.012;
        }
        public double toFranc(double x)
        {
            return x * 0.011;
        }
        public double toEuro(double x)
        {
            return x * 0.011;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RupeeConverter rc = new RupeeConverter();
            Console.Write("Enter ruppes : ");
            double ruppes = double.Parse(Console.ReadLine());
            Console.WriteLine("Dollar is : " + rc.toDollar(ruppes));
            Console.WriteLine("Franc is  : " + rc.toFranc(ruppes));
            Console.WriteLine("Euro is   : " + rc.toEuro(ruppes));
            Console.ReadKey();
        }
    }
}
