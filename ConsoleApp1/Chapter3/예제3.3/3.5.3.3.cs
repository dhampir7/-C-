/*3.5.3.3 goto 문 ) goto를 사용하려면 제어 흐름이 옮겨지는 대상을 구분하기 위해 레이블 문이 있어야 함. 레이블 문은 식별자에 콜론(':')을 붙여서 만드는데,
관례상 대문자로만 쓰는 것이 일반적임*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int n = 0;

		LOOP:
			n++;
			if (n > 1000)
			{
				goto LOOPEXIT;
			}

			if ((n % 2) != 0) goto LOOP;

			sum += n;
			goto LOOP;

		LOOPEXIT:
			Console.WriteLine(sum);
		}
    }
}