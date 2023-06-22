/*@ 문자 사용하면 내부에 \를 이스케이프 시퀀스로 간주 X*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = @"\tHello\nWorld";
			Console.WriteLine(text);
		}
	}
}