/*3.2.2 명시적 변환*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			ushort u = 65;
			char c = (char)u;
			Console.WriteLine(c);	// 출력 결과: A
		}
	}
}