/*3.2.2 명시적 변환*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 40000;
			short s = (short)n;
			Console.WriteLine(s);   // 출력 결과: -25536
        }
	}
}