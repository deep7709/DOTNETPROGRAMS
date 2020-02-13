using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Infix");
            string infix = "a+b";
            ClassA obj = new ClassA();
            string postfix = " ";
            obj.infixtopostfix(infix ,out postfix);
            Console.WriteLine(postfix);
            Console.ReadLine();



        }
    }
}
