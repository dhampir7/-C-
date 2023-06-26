/*값 형식과 참조 형식의 차이점이 잘 나타나는 경우가 또 한가지 있음, 바로 변수의 값을 또 다른 변수에 대입했을 때
 n1과 n2가 같은 값이고, txt1과 txt2 역시 같은 값을 출력하지만 값 형식과 참조 형식에 따라 메모리의 표현 방식은 서로 다르다.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1 = 5;
			int n2 = n1;

			Console.WriteLine(n1);      // 5를 출력
            Console.WriteLine(n2);      // 5를 출력

			string txt1 = "C#";
			string txt2 = txt1;

            Console.WriteLine(txt1);    // "C#"을 출력
            Console.WriteLine(txt2);	// "C#"을 출력
        }
	}
}