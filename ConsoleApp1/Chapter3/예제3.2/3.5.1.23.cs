/*조건이 여러 개인 경우 if/else if/else로 표현하는 것도 가능*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 5;
			if (value <= 255)
			{
				Console.WriteLine("byte 변환 가능");
			}
			else if (value <= 65535)
			{
				Console.WriteLine("ushort 변환 가능");
			}
			else
			{
				Console.WriteLine("int 타입");
			}
        }
	}
}