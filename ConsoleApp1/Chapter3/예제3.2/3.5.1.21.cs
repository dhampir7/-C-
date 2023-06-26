/*블록 안에는 0개 이상의 구문이 올 수 있으며, 
순차적으로 실행됨. 따라서 여러 개의 구문을 실행해야 한다면 블록 내에 원하는 코드를 적절한 순서에 맞게 추가하면 됨*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			if (6 %  3 == 0)
			{
				Console.WriteLine("6은 3의 배수");
                Console.WriteLine("연산 결과 끝!");
            }
        }
	}
}