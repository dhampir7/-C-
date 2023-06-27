/*3.5.2.5 while 문 ) 보통 for 문을 사용할 때 초기화, 조건식, 반복문을 지정하는데,
 때로는 간편하게 조건식만 있는 반복문이 필요할 때도 있음.
물론 for 문의 괄호 안에 해당 코드를 삭제하는 것도 가능하지만 C#에서는 이런 경우에 쓸 수 있게 while 반복문을 문법적으로 제공함*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;

            while (n <= 1000)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }

                n++;
            }
            Console.WriteLine(sum); // 출력 결과: 250500
        }
    }
}