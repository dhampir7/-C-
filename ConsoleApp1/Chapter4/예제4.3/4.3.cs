/*보다시피 f라는 이름의 메서드 역시 클래스에 필드를 선언할 때처럼 public이라는 한정자를 명시했음.
필드를 사용할 때와 마찬가지로 public을 지정하지 않으면 
기본적으로 클래스(예:Mathematics) 안에 정의되는 모든 메서드는 외부(예: class Program)에서 사용할 수 없음.
클래스에서 제공하는 메서드를 호출할 때도 필드에서처럼 마침표(.)를 찍고 해당 클래스에서 제공하는 메서드명을 쓰면 됨.*/

using System;

namespace ConsoleApp1
{
    class Mathematics
    {
        public int f(int x)
        {
            return x * x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int result = m.f(5);
            Console.WriteLine(result);  // 출력 결과: 25
        }
    }
}