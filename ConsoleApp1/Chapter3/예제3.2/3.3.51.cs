/*3.3.5 상수*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = Math.Max(0, 5);	// 프로그램을 실행할 때 n의 값이 결정된다.
									// 0과 5 중에서 5가 크므로 변수 n에는 5가 대입

			const int maxN = Math.Max(0, 5);    // Math.Max 메서드가 실행된 이후에야 값이 결정되고,
												// 컴파일러가 미리 그 값을 결정할 수 없으므로
												// 오류가 발생한다.
        }
	}
}