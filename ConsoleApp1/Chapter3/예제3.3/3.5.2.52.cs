/*자세히 보면 while 문은 실행 순서가 조건식 -> 구문 -> ......으로 반복 되지만 
do/while문은 그 반대로 구문이 먼저 실행된 후 조건식이 평가되는 것을 볼 수 있음
그렇다고 해도 변수를 증가시키는 반복 구조에서는 초기 변숫값을 어떻게 초기화하느냐 정도의 차이만 있을 뿐 
이것도 역시 while 문으로 작성한 코드를 그대로 옮길 수 있다.*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
        {
            int sum = 0;
            int n = 0;  // 초기값이 0으로 변경됨
            do
            {
                if (n % 2 == 0) sum += n;
            } while (++n <= 1000);
        }
    }
}