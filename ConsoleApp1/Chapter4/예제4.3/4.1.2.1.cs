/*동일한 코드가 중복되는 것을 볼 수 있다. 나중에 짝수가 아니라 홀수로 요구 조건이 바뀌었다고 가정해 보자.
개발자는 일일이 중복된 코드를 찾아 모두 변경해야 하는데, 그 과정에서 특정 조건을 놓치면 프로그램이 오동작할 수 있다.
즉, 중복된 코드는 향후 유지보수를 어렵게 만든다는 심각한 단점이 있다. 메서드를 사용하면 이런 문제를 개선할 수 있다.*/

using System;

namespace ConsoleApp1
{
    static void Main(string[] args)
    {
        int x = 5;
        if (x % 2 == 0)
        {
            Console.WriteLine(x);
        }

        x = 10;
        if (x % 2 == 0)
        {
            Console.WriteLine(x);
        }
    }
}