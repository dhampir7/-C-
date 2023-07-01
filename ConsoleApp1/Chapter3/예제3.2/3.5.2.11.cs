/*증감 연산자, 복합 대입 연산자*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 50;
			Console.WriteLine(n++);     // n을 평가하고 난 다음 1만큼 증가

			n = 50;
			Console.WriteLine(++n);		// n의 값을 1만큼 증가시키고 식을 평가
		}
	}
}