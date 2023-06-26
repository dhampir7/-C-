/*';'(세미콜론)은 한 구문의 끝을 컴파일러에게 알리는 문장 부호*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "Hello"; text = text + " World";
			Console.WriteLine(text);	// 출력 결과: Hello World
        }
	}
}