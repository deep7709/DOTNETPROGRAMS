using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number to convert:");
            string d = Console.ReadLine();
            Console.WriteLine("Binary : " + Class1.decimal2binary(d));
            Console.WriteLine("Decimal : " + Class1.binary2decimal(Class1.decimal2binary(d)));
            Console.WriteLine("Octal : " + Class1.decimal2octal(d));
            Console.WriteLine("Hex : " + Class1.decimal2hex(d));
            Console.ReadLine();
        }

    }
}