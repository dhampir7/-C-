/*4.1.2.1 중복 코드 제거*/

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