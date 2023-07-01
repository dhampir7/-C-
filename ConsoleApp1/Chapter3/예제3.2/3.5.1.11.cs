/*3.5.1.1 관계 연산자, 논리 연산자*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 10;
			int n1 = value % 3;
			int n2 = value % 5;

			bool orResult = (n1 == 0 || n2 == 0);
			Console.WriteLine("value는 3의 배수이거나 5의 배수: " + orResult);

			bool andResult = (n1 == 0 && n2 == 0);
			Console.WriteLine("value는 3과 5의 배수: " + andResult);

			bool notResult = !(n1 == 0);
			Console.WriteLine("value는 3의 배수가 아님: " + notResult);
        }
	}
}