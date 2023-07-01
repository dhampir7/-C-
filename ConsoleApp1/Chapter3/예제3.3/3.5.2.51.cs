/*3.5.2.5 while 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 1; n <= 1000; n ++)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
        }
    }
}