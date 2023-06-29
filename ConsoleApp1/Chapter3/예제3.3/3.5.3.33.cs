/*1~999까지 반복(+1씩 증가, 1,000보다 작은 자연수이므로 1,000을 포함하지 않음)
3과 5의 배수가 아니면 다음 반복으로 진행
그렇지 않으면 모두 더한다
반복문이 끝났으면 더한 값을 출력*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 1, sum = 0;

			while (n < 1000)
			{
				if ( n % 3 == 0 || n % 5 == 0)
				{
					sum += n;
				}

				n++;

			}

			Console.WriteLine(sum);
		}
    }
}