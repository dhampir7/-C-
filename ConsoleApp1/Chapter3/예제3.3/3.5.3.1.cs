/*3.5.3.1 continue 문 ) break 문이 루프를 벗어나는 반면
 continue 문은 이후의 반복 구문 실행을 생략하고 곧바로 조건식평가로 실행을 옮기면서 반복을 계속한다는 차이가 있음*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int n = 1;

			while (n ++ <= 1000)
			{
				if ((n % 2) != 0)
				{
					continue;	// sum += n;	구문을 건너뛰고, while 문의 조건식 평가로 실행을 옮긴다.
				}

				sum += n;
			}
		}
    }
}