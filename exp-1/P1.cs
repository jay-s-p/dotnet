﻿/*
Write a C# program for string manipulation.
*/
using System;

namespace Zzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "   Hello   World   ";
            string s2 = "   World   Hello   ";

            if (s1.Equals(s2))
                Console.WriteLine("Both strings are equals!");
            else
                Console.WriteLine("Both strings are not equals!");

            Console.WriteLine("\nCompare s1 with s2 :-\n" + s1.CompareTo(s2));
            Console.WriteLine("\nLength of s1 is:-\n" + s1.Length);
            Console.WriteLine("\nUppercase s1 :-\n" + s1.ToUpper());
            Console.WriteLine("\nLowercase s1 :-\n" + s2.ToLower());
            Console.WriteLine("\nConcat s1 and s2 :-\n" + (s1 + s2));
            Console.WriteLine("\nTrimmed s1 :-\n" + s1.Trim());
            Console.WriteLine("\nReplace l with y in s1 :-\n" + s1.Replace('l', 'y'));
            Console.WriteLine("\nSubstring s1 :-\n" + s1.Substring(4, 9));
            Console.WriteLine("\nRemove s1 part :-\n" + s1.Remove(6, 3));
            Console.ReadKey();
        }
    }
}
