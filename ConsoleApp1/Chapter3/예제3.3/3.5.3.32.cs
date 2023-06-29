/*전체 루프를 완전히 탈출하기 위해 별도의 조건 변수를 두고 이중으로 써야 하는 구조가 나온다. 
이런식으로 3중, 4중 루프가 있다고 생각하면 가히 좋은 방법이 아님을 알 수 있다.
이럴 때 goto 문을 쓰면 오히려 더 이해하기 쉬운 구조로 바뀐다. */

using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int x = 2; x < 10; x ++)
			{
				for (int y = 1; y < 10; y ++)
				{
					Console.WriteLine(x + "*" + y + " = " + (x * y));

					if (x == 5 && y == 8) goto LOOP_EXIT;
				}
			}

		LOOP_EXIT:;
		}
    }
}