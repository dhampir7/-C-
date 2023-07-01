/*3.5.2.3 중첩 루프*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            for (int x = 2; x < 10; x ++)
                for (int y = 1; y < 10; y ++)
                    Console.WriteLine(x + " * " + y + " = " + (x * y));

            // 또는 실행할 구문이 하나인 경우에도 다음과 같이 가독성을 높이기 위해
            // 일부러 블록을 사용하기도 한다.

            for (int x = 2; x < 10; x ++)
            {
                for (int y = 1; y < 10; y ++)
                {
                    Console.WriteLine(x + " * " + y + " = " + (x * y));
                }
            }
        }
    }
}