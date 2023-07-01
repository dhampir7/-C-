/*3.5.1.3 switch 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "C#";

			if (text == "C#" || text == "VB.NET")
			{
				Console.WriteLine("NET 호환 언어");
			}
			else if (text == "Java")
			{
				Console.WriteLine("JVM 언어");
			}
			else
			{
				Console.WriteLine("알 수 없음");
			}
		}
	}
}