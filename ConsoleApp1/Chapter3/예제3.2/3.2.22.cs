/*큰 데이터 타입에서 작은 데이터 타입으로 형변환할때 '명시적 변환' 사용*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 40000;
			short s = (short)n;
			Console.WriteLine(s);   // 출력 결과: -25536

        }
	}
}