/*3.3.5 상수*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			const bool result = false;
			const int n = 5;
			const string text = "Hello";

			result = true; // 컴파일 오류 발생! const 상수 값은 바꿀 수 없다.
        }
	}
}