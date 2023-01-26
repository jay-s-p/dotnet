/*
Write a C# program for delegate.
*/
using System;

namespace Zzz
{
    public delegate string del(string str, int a);

    class test
    {
        public static string encrypt(string str, int a)
        {
            char[] m = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
                m[i] = Convert.ToChar(str[i] + a);
            return new String(m);
        }
        public static string decrypt(string str, int a)
        {
            char[] m = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
                m[i] = Convert.ToChar(str[i] - a);
            return new String(m);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            del enc = new del(test.encrypt);
            del dec = new del(test.decrypt);

            string str = "abc";
            Console.Write("Encryption of " + str + " is " + enc(str, 2));
            str = "cde";
            Console.Write("\n\nDecryption of " + str + " is " + dec(str, 2));
            Console.ReadKey();
        }
    }
}