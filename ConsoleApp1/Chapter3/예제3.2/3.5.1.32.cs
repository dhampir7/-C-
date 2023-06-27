/*첫 번째 case 문에 break가 없기 때문에 조건이 그다음 case 문과 합쳐져서 실행돼야 할 구문을 공유하고 있음을 확인할 수 있음.
 이를 if 문으로 나타내면 다음과 같이 표현할 수 있음*/

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