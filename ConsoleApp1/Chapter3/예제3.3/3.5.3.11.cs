/*break와 continue는 가독성을 높이기 위해 들여쓰기 블록을 줄이는 역할도 한다. 다소 억지스럽긴 하지만 다음과 같은 경우를 가정*/

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
				if ((n % 3) == 0)
				{
					if ((n % 5) == 0)
					{
						sum += n;
					}
				}
			}
		}
    }
}