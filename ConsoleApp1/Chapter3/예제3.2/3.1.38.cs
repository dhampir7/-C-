/*char 형과 달리 string은 '+' 연산을 지원하며 문자열끼리 연결 가능*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "Hello";
			Console.WriteLine(text + " " + "World");
		}
	}
}