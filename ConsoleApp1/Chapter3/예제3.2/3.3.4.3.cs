/*3.3.4.3 참조 형식을 가리키는 변수 ) 값을 할당하지 않은 string변수는 스택 변수의 값이 숫자 0을 담음.
 즉, 가리킬 수 있는 힙 주소가 없음. But 참조형 변수의 경우 숫자 0을 대입할 수는 없으므로*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string text;
        }
	}
}