/*3.5.2.2 for 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int n = 1;

            for (; ; n++)
            {
                if (n > 9) break;

                Console.WriteLine(n);
            }
        }
    }
}