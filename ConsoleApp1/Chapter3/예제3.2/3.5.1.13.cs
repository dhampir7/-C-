/*||(OR) 연산과 마찬가지로 단락 계산은 $$ 논리곱 연산에서도 발생
(n1 % 3) == 0의 표현식이 거짓이므로 논리곱 연산의 성격상 뒤에 오는 식에 상관없이 전체 평가식이 거짓이 됨
따라서 이번에도 역시 (n2 % 3 == 0) 코드는 실행 되지 않음*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1 = 10;
			int n2 = 6;
			bool result = (n1 % 3 == 0 && n2 % 3 == 0); // result == False
        }
	}
}