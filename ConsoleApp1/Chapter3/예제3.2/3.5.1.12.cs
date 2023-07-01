/*3.5.1.1 관계 연산자, 논리 연산자*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1 = 6;
			int n2 = 10;
			bool result = (n1 % 3 == 0 || n2 % 3 == 0);
			Console.WriteLine("n1 또는 n2는 3의 배수: " + result);
        }
	}
}