/*대괄호 안에 지정되는 수를 색인(index)이라고 한다.
 기본 자료형을 배우면서 변수를 선언할 때 값을 함께 초기화할 수 있다는 사실을 배웠는데, 배열의 경우 특이하게 2가지 방법으로 초기화하는 것이 가능*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			products[0] = 100;
			products[1] = 200;

			int book = products[0];

			int sum = products[0] + products[1];
        }
	}
}