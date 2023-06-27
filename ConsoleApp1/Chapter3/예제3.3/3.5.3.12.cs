/*continue 문을 적절히 사용하면 눈으로 따라가서 추적해야 하는 "들여쓰기"나 "블록"의 수를 줄일 수 있으므로 코드를 읽고 이해하기가 더 쉬워짐*/

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
				if ((n % 2) != 0) continue
				if ((n % 3) != 0) continue
				if ((n % 5) != 0) continue

				sum += n;
			}
		}
    }
}