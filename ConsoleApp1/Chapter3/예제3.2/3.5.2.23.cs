/*3.5.2.3 중첩 루프 ) 제어문은 기본적으로 구문 하나를 제어할 수 있지만 블록을 사용하는 경우 여러 개의 구문을 제어할 수 있음.
 그리고 그 구문에는 다시 제어문이 포함될 수 있는데, 예를 들어 for 루프 안에 또 다시 for 루프가 있다면 이를 "중첩 루프(nested loop)"라 함*/

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