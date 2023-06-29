/*GetValue와 Output 메서드의 정의는 낯설지 않은 반면, 그것을 호출하는 코드는 다소 낯설게 느껴질 수 있다.
여기서는 m.GetAreaOfSquare 메서드를 호출하고 인자로 m.GetValue 메서드 호출을 전달했는데, 
사실 이것은 수학의 함수를 사용하는 방법을 떠올려보면 당연한 표현이다.*/

using System;

namespace ConsoleApp1
{
    class Mathematics
    {
        public int GetAreaOfSquare(int x)
        {
            return x * x;
        }

        public int GetValue()   // 매개변수는 없고 값만 반환
        {
            return 10;
        }

        // 2개의 매개변수를 받고, 반환값이 없음
        public void Output(string prefix, int value)
        {
            Console.WriteLine(prefix + value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.GetAreaOfSquare(m.GetValue());

            m.Output("결과 : ", result);
        }
    }
}