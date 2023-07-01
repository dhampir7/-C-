/*3.5.2.5 while 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int sum = 0;
            int n = 0;  // 초기값이 0으로 변경됨
            do
            {
                if (n % 2 == 0) sum += n;
            } while (++n <= 1000);
        }
    }
}