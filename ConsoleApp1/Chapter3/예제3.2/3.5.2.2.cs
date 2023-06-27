/*3.5.2.2 for 문 ) for 문은 프로그래밍 언어에서 꽤나 고전적인 반복문에 해당. 
 for 문은 C#뿐만 아니라 대부분의 프로그래밍 언어에서 제공하며 그 문법도 대개 같다*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int n;

            for (n = 1; n <= 9; n++)
            {
                Console.WriteLine(n);
            }
        }
    }
}