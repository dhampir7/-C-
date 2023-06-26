/*개별 조건식의 결과는 반드시 bool 타입이므로 조건식을 나열한다는 것은 곧 부울 대수(boolean algebra)의 기본 연산을 하는 것과 같음.
 바로 이때 사용되는 것이 C#의 논리 연산자로서 &&(AND: 논리곱), ||(OR: 논리합), !(NOT: 부정), ^(XOR: 배타적 논리합)의 4가지가 있음 */

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 10;
			int n1 = value % 3;
			int n2 = value % 5;

			bool orResult = (n1 == 0 || n2 == 0);
			Console.WriteLine("value는 3의 배수이거나 5의 배수: " + orResult);

			bool andResult = (n1 == 0 && n2 == 0);
			Console.WriteLine("value는 3과 5의 배수: " + andResult);

			bool notResult = !(n1 == 0);
			Console.WriteLine("value는 3의 배수가 아님: " + notResult);
        }
	}
}