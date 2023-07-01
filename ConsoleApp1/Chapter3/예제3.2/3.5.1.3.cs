/*3.5.1.3 switch 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			char ch = 'F';

			switch (ch)
			{
				case 'M':
                    Console.WriteLine("남성");
					break;
				case 'F':
                    Console.WriteLine("여성");
					break;

				default:
					Console.WriteLine("알 수 없음");
					break;
			}
		}
	}
}