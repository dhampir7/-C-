/*증감 연산자, 복합 대입 연산자*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 50;
			int result;
			result = n++;   // result에 50을 대입한 후 값을 51로 증가, result의 값은 50

			n = 50;
			result = ++n;   // n의 값을 51로 증가시킨 후에 result에 값을 대입, result의 값은 51

			n = 50;
			result = n--;   // result에 50을 대입한 후에 값을 49로 감소, result의 값은 50

			n = 50;
			result = --n;   // n의 값을 49로 감소한 후에 result에 값을 대입, result의 값은 49
		}
	}
}