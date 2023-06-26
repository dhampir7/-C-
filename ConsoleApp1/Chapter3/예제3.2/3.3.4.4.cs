/*3.3.4.4 기본값 ) 값 형식을 가리키는 변수는 해당 자료형에 대해 무조건 메모리가 할당되므로
 그 메모리 영역에 필연적으로 기본값(default value)을 갖게 된다. 닷넷은 자료형에 대한 메모리를 할당하면 해당 영역을 무조건 0으로 초기화 한다.
따라서 값 형식의 변수를 선언할 때 개발자가 명시적으로 값을 초기화하지 않았다면 숫자형은 0을, bool은 false를 기본값으로 갖는다.
반면 참조 형식의 경우에는 이전 절에서 이야기한 대로 모두 null 값을 가진다.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			bool result;    // 변수 result에는 false 값이 들어 있다.
			int n;  // 변수 n에는 0 값이 들어 있다.
			string text;	// 변수 text에는 null 값이 들어 있다.
        }
	}
}