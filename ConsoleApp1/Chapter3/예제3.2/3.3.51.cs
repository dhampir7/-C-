/*Math.Max는 코드로서 실행돼야 하므로 컴파일러 입장에서 어떤 값을 대입해야 할지 컴파일 시점에는 알 수 없기 때문임*/

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