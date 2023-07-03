/*4.3.2.1 ToString*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 500;
            double d = 3.1415926535897932384626;

            string txt = "Hello: ";

            Console.WriteLine(txt + n.ToString());
            Console.WriteLine(txt + d.ToString());

            txt = d.ToString();

            Console.WriteLine(txt);
        }
    }
}