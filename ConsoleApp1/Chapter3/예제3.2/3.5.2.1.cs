/*증감 연산자, 복합 대입 연산자) 증감 연산자에서 특별하게 알아둬야 할 것이 있다면 바로 전위(prefix)/후위(postfix) 표기법
 즉, ++와 -- 연산자가 피연산자의 앞에 오느냐 뒤에 오느냐에 따라 동작 방식이 바뀜*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 50;
			n++;    // 증가 연산자 후위 표기법
			n--;    // 감소 연산자 후위 표기법

			++n;    // 증가 연산자 전위 표기법
			--n;	// 감소 연산자 전위 표기법
		}
	}
}