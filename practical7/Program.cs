using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, f, ch;
            Console.WriteLine("1.C To F");
            Console.WriteLine("2.F To C");

            ch = int.Parse(Console.ReadLine());

            switch(ch)
            {
                case 1 :  
                    
                    Console.WriteLine("Enter C Value");
                    c=int.Parse(Console.ReadLine());
                    f=(c*(9/5))+32;
                    Console.WriteLine("C To F Value is" + f);
                    break;

                case  2 :

                     Console.WriteLine("Enter F Value");
                     f=int.Parse(Console.ReadLine());
                     c=f-32*(5/9);
                     Console.WriteLine("F To C Value is" + c);
                     break;

                default :
                     break;
            }

            Console.ReadLine();


        }
    }
}
