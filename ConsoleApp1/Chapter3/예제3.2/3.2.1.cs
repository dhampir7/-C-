/*3.2.1 암시적 변환*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			byte b = 250;
			short s = b;

			Console.WriteLine(s);	// 출력 결과: 250
		}
	}
}