/*C#에는 if 문의 한 가지 전형적인 사용 사례에 대해 간단하게 줄여서 작성할 수 있게 연산자 차원에서 지원하고 있음,
이를 조건 연산자(삼항 연산자)라고 함*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = 5;
			string result;
			if (value % 2 == 0)
			{
				result = "짝수";
			}
			else
			{
				result = "홀수";
			}

			Console.WriteLine(result);	// 실행 결과: 홀수
        }
	}
}