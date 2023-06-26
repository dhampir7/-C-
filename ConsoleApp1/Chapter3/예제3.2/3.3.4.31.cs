/*이런 목적으로 C#은 특별하게 null 예약어를 준비해둠. 따라서 아래의 두 가지 스택 변수는 동일하게 숫자 0을 담고있게됨.
 즉, 초기화되지 않은 모든 참조형 변수는 null 값을 가짐.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text1;
			string text2 = null;
        }
	}
}