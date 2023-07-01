/*3.5.1.2 if문*/

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