/*전자는 배열의 수를 지정했기 때문에 배열을 초기화하려면 반드시 그 수만큼의 요소를 나열해야 하는 반면
후자는 개발자가 명시적으로 배열의 수를 지정하지 않은 채로 초기화 요소를 나열했으므로 
컴파일러는 그 수만큼 계산해서 자동으로 배열의 크기를 5로 지정*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] products = new int[5] { 1, 2, 3, 4, 5 };  // 배열의 요소 개수를 지정

			int[] products = new int[] { 1, 2, 3, 4, 5 };	// 배열의 요소 개수를 미지정
        }
	}
}