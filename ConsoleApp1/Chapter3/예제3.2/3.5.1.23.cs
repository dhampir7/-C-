/*3.5.1.2 if문*/

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