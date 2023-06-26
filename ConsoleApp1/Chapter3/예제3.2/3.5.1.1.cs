/*3.5.1.1 관계 연산자, 논리 연산자*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 6;
			int n = value % 3;
			bool result = (n == 0);

			Console.WriteLine(result);	// 출력 결과: True
        }
	}
}