/*for 문의 괄호 안에 있던 3개의 코드를 모두 제거할 수 있었지만 세미콜론(;) 구분자는 여전히 남아 있어야 함
 세미콜론까지 생략하면 컴파일 과정에서 구문 오류가 발생함.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int n = 1;

            for (; ; )
            {
                if (n > 9) break;

                Console.WriteLine(n);
                n++;
            }
        }
    }
}