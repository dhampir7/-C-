/*조건식도 마저 생략한다면 if 문으로 조건식을 대체할 수 있음*/

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