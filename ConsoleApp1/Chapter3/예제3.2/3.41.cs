/*여기서 새롭게 new라는 예약어와 함께 배열을 정의하기 위한 대괄호(square bracket) 문장부호를 볼 수 있다.
 C#에서 new 키워드는 참조 형식과 함께 사용되는 경우 그에 필요한 메모리를 힙(Heap)에 할당하는 역할을 한다.
그리고 변수를 선언할 때 대괄호를 사용하면 해당 변수가 배열임을 의미한다.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] products = new int[5];

			string[] names = new string[1000];
        }
	}
}