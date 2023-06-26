/*부울 대수에 따라 실행할 때 단락 계산(short-circuit) 이 두 가지 상황에서 발생할 수 있다.
예를 들어, || 논리합 연산을 할 때 이미 (n1 % 3 == 0)의 표현식이 참이기 때문에 뒤의 (n2 % 3 == 0)의 결과값에 상관없이 전체 평가식이 참이 됨.
이런 이유로 프로그램의 실행 과정에서 뒤의 조건은 아예 실행조차 되지 않는 것을 두고 
단락 계산 또는 단축 평가(short-circuit evaluation)됐다고 함.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1 = 6;
			int n2 = 10;
			bool result = (n1 % 3 == 0 || n2 % 3 == 0);
			Console.WriteLine("n1 또는 n2는 3의 배수: " + result);
        }
	}
}