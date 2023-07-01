/*3.5.1.3 switch 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "C#";

			// 이 switch에는 default가 없다
			switch (text)
			{
				case "C#":
					Console.WriteLine(".NET 호환 언어");
					break;

				case "Java":
					Console.WriteLine("JVM 언어");
					break;
			}
		}
	}
}