/*가만 보니 그동안 다룬 기본 예제에도 System이라는 네임스페이스가 사용된 것을 볼 수 있다.
왜냐하면 Console 클래스가 실제로는 System 네임스페이스 내부에 정의됐기 때문에 코드의 첫부분에서 using으로 미리 알린 것이다.
만약 "using System;"을 제거한다면 Console 클래스를 사용할때마다 "System.Console.WriteLine"과 같이 써야 한다.
또한 우리가 정의한 Program 클래스는 ConsoleApp1 네임스페이스 아래에 두고 있다.
이처럼 네임스페이스를 끝으로 이제야 비로소 우리는 기본 예제 코드를 완벽하게 이해할 수 있는 단계에 온 것이다.*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 출력
            Console.WriteLine("Hello World");
        }
    }
}
