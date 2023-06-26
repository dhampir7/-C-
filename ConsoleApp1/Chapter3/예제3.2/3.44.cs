/*배열을 다룰 때 한 가지 주의할 사항은 한번 정해진 배열의 크기는 고정된다는 점
물론 참조 변수의 특성상 가리키는 대상이 변할 수 있기 때문에 다음과 같이 변경된 크기의 배열을 다시 가리키는 것은 가능하지만 
그래도 처음에 있었던 배열의 크기가 변경된 것은 아님*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] students = new int[60];
			students[0] = 50;
			Console.WriteLine(students[0]); // 출력 결과: 50

			students = new int[120];
			Console.WriteLine(students[0]);	// 출력 결과: 0
        }
	}
}