/*switch 문에서 마지막으로 언급할 사항은 default 구문이 강제 사항이 아니라는 점.
즉, 필요하지 않으면 생략해도 무방*/

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