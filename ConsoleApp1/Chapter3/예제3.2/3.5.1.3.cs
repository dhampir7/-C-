/*3.5.1.3 switch 문 ) switch 문은 사실 if 문의 특수한 형태에 해당. 
여러 개의 조건을 판단해서 실행할 때 if/else if/else if/....../else 구문을 쓸 수도 있지만 
조건 판단의 기준이 되는 식이 상수라면 switch 구문을 쓰는 것이 편리할 수 있음
즉, 모든 switch 문은 다중 if 문으로 변환할 수 있지만 반대로 특정한 경우의 다중 if 문만이 switch 문으로 변환될 수 있다.*/

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