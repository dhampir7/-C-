/*후위 표기법은 피연산자 값이 평가된 후 값을 증가/감소시키는 것, 전위 표기법은 피연산자의 값을 증가/감소시킨 후에 식을 평가하게 됨.*/

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