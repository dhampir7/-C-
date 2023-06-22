/*3.2.2 명시적 변환 ) 2바이트인 ushort 형의 데이터가 동일하게 2바이트인 char 형으로 대입될때 명시적 변환 예시*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			ushort u = 65;
			char c = u;
		}
	}
}