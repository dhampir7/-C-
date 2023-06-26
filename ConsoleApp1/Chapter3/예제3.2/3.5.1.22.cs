/*if 문은 조건식의 결과가 참인 경우뿐 아니라 거짓인 경우에도 실행할 수 있는 구문을 else 예약어를 추가해 지정 가능*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 5;
			if (value % 2 == 0)
			{
				Console.WriteLine("value는 2의 배수");
				Console.WriteLine("따라서 value는 짝수");
			}
			else
			{
				Console.WriteLine("value는 홀수");
			}
        }
	}
}