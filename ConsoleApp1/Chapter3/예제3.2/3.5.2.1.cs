/*증감 연산자, 복합 대입 연산자*/

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