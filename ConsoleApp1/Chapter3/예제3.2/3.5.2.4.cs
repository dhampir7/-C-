/*설명: 표현식에 올 수 있는 대표적인 자료형은 배열이다. 배열인 경우 배열의 요소 수만큼 구문이 반복되며,
각 반복마다 배열요소의 값을 변수명에 넣어서 실행한다(참고로 아직 배우지는 않았지만 표현식에는 나중에 배울 켈렉션이라는 자료형도 사용할 수 있다)*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach (int elem in arr)
            {
                Console.WriteLine(elem);
            }
        }
    }
}