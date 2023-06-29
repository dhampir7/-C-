/*현재 유일하게 goto 문이 유용하다고 합의를 보는 사례는 "중첩 루프에서 탈출"하는 경우에 한해서임.
예제 상황을 일부러 만들어 보기 위해 중첩 루프를 사용하는 구구단 프로그램에서 중간의 5 * 8 까지만 출력하고 끝내는 코드를 goto 문 없이 작성함*/

using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool exitLoop = false;

			for (int x = 2; x < 10; x ++)
			{
				for (int y = 1; y < 10; y ++)
				{
                    Console.WriteLine(x + " * " + y + " = " + (x * y));

                    exitLoop = x == 5 && y == 8;
					if (exitLoop == true)
					{
						break;
					}
                }

				if (exitLoop == true)
				{
					break;
				}

			}
		}
    }
}