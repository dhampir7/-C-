/*'='는 대입 연산자(assignment operator)*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 5;
			int divider = 3;
			int mod = n % divider;
			Console.WriteLine(mod);	// 출력 결과: 2
        }
	}
}