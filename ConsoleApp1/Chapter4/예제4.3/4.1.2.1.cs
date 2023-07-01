/*4.1.2.1 중복 코드 제거*/

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