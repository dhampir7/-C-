/*for 문을 사용하는 것도 가능*/

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