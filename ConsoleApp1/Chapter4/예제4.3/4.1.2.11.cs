/*관리해야 할 코드가 한곳에 모이고, 이를 재사용할 수 있기 때문에 좀 더 간결하게 프로그램을 만들 수 있다. 원칙은 간단하다.
한 번만 사용하면 되는 코드를 메서드로 분리해야 할지에 대해서는 '선택의 문제'지만 해당 코드가 두 번 이상 중복된다면 무조건 메서드로 분리하자.*/

using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    class Mathematics
    {
        public void PrintIfEven(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine(value);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Mathematics m = new Mathematics();

        int x = 5;
        m.PrintIfEven(x);

        x = 10;
        m.PrintIfEven(x);
    }
}