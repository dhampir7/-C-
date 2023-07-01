/*3.5.1.2 if문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 5;
			if (value % 2 == 0)
			{
				Console.WriteLine("value는 2의 배수");
				Console.WriteLine("따라서 value는 짝수");
			}
			else
			{
				Console.WriteLine("value는 홀수");
			}
        }
	}
}